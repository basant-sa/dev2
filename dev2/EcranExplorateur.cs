using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dev2
{
    public partial class EcranExplorateur : Form

    {

        public EcranExplorateur()
        {
            InitializeComponent();
        }

        private void EcranExplorateur_Load(object sender, EventArgs e)
        {
            RemplirTreeView();
        }

        private void RemplirTreeView()
        { 
            LireDisques();
        }

        private string GetChemin(TreeNode node)
        {
            string chemin = node.Text;

            while (node.Parent != null)
            {
                node = node.Parent;
                chemin = Path.Combine(node.Text, chemin);
            }

            return chemin;
        }

        private void LireRepertoires(string chemin, TreeNode parent)
        {
            try
            {
                string[] repertoires = Directory.GetDirectories(chemin);

                foreach (string rep in repertoires)
                {
                    TreeNode noeud = new TreeNode(Path.GetFileName(rep));

                  
                    noeud.Nodes.Add("...");

                    parent.Nodes.Add(noeud);
                }
            }
            catch { }
        }

        private void LireDisques()
        {
            tvRepertoiree.Nodes.Clear();
            string[]disques=Environment.GetLogicalDrives();

            foreach (string disque in disques)
            {
                TreeNode noeud=new TreeNode(disque);    
                tvRepertoiree.Nodes.Add(noeud);
                LireRepertoires(disque, noeud);
            }
            
        }

        private void tvRepertoiree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            string chemin= GetChemin(e.Node);
            LireRepertoires(chemin, e.Node);


        }

        private void tvRepertoiree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = GetChemin(e.Node);

            LireFichiers(chemin);
        }

        private void LireFichiers(string chemin)
        {
            try
            {
                lvFichiers.Items.Clear();

                string[] fichiers = Directory.GetFiles(chemin);

                foreach (string fichier in fichiers)
                {
                    FileInfo info = new FileInfo(fichier);

                    ListViewItem item = new ListViewItem(info.Name);

                    item.SubItems.Add(info.Length.ToString());
                    item.SubItems.Add(info.CreationTime.ToString());
                    item.SubItems.Add(info.LastWriteTime.ToString());

                    lvFichiers.Items.Add(item);
                }
            }
            catch
            {

            }
        }
    }
}

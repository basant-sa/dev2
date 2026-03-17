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
    }
}

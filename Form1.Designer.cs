using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PBR_Showroom
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public int img_size = 256;
        public List<Bitmap> b_list = new List<Bitmap>();
        public List<PictureBox> p_list = new List<PictureBox>();
        public List<string> img_url_list = new List<string>();
        public List<string> directory_list = new List<string>();

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 388);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.search_from_tree);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 388);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 17);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Material name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert new material";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.on_insert);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.search);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reset_thumbnails);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(252, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 40);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 394);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PBRShowroom";
            this.ResizeEnd += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        public void test()
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            show_directory_clean(dir, this.treeView1.Nodes);
            this.resize();
        }

        public void show_directory_clean(string directory_name, System.Windows.Forms.TreeNodeCollection treeNodeCollection)
        {
            directory_list.Add(directory_name);
            string name = Path.GetFileName(directory_name);
            System.Windows.Forms.TreeNode inserted = treeNodeCollection.Add(name);
            int index = treeNodeCollection.IndexOf(inserted);
            string[] dirs = Directory.GetDirectories(directory_name);
            if (dirs != null)
            {
                foreach (string dir in dirs)
                {
                    if (!dir.Contains("library"))
                    {
                        show_directory_clean(dir, treeNodeCollection[index].Nodes);
                    }
                }
            }
        }

        public void find_thumbnails(string directory_name)
        {
            string[] files = Directory.GetFiles(directory_name);
            if (files != null)
            {
                foreach (string f in files)
                {
                    if (f.Contains("thumbnail"))
                    {
                        img_url_list.Add(f);
                    }
                }
            }
            string[] dirs = Directory.GetDirectories(directory_name);
            if (dirs != null)
            {
                foreach (string dir in dirs)
                {
                    find_thumbnails(dir);
                }
            }
        }

        public void find_thumbnails_detailed(string directory_name,string search)
        {
            string[] files = Directory.GetFiles(directory_name);
            if (files != null)
            {
                foreach (string f in files)
                {
                    if (f.Contains("thumbnail") && f.ToLower().Contains(search))
                    {
                        img_url_list.Add(f);
                    }
                }
            }
            string[] dirs = Directory.GetDirectories(directory_name);
            if (dirs != null)
            {
                foreach (string dir in dirs)
                {
                    find_thumbnails_detailed(dir,search);
                }
            }
        }

        public void useless(string[] list, int index)
        {
            string f = list[index];
            PictureBox img = new PictureBox();
            this.p_list.Add(img);

            Bitmap bitmap = (Bitmap)Image.FromFile(f);
            Bitmap newBitmap = new Bitmap(bitmap, 256, 256);
            string n = Path.GetFileName(f);
            string path = Path.GetDirectoryName(f);
            newBitmap.SetResolution(32, 32);
            bitmap.Dispose();
            this.b_list.Add(newBitmap);
            img.Image = newBitmap;
            img.Width = this.img_size;
            img.Height = this.img_size;
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.MouseClick += picture_click;
            img.BackColor = Color.FromArgb(31,31,31);
            img.Refresh();
            MethodInvoker inv = delegate
            {
                this.flowLayoutPanel1.Controls.Add(img);
            };
            this.Invoke(inv);
        }

        public void show_thumbnails()
        {
            foreach (PictureBox p in p_list)
            {
                p.Refresh();
            }
        }

        public void resize()
        {
            this.panel2.Width = this.Width;
            this.treeView1.Height = this.Height - 100;
            this.treeView1.Width = this.Width / 8;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(this.treeView1.Width + 1, this.treeView1.Location.Y);  ;
            this.flowLayoutPanel1.Height = this.Height - 100;
            this.flowLayoutPanel1.Width = ( (this.Width/8)*7 );
            this.flowLayoutPanel1.AutoScroll = true;
            this.img_size = this.flowLayoutPanel1.Width / 6;
            show_thumbnails();
        }

        private void picture_click(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Bitmap b = (Bitmap)p.Image;
            Process.Start(Path.GetDirectoryName(this.img_url_list[this.b_list.IndexOf(b)]));
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            resize();
        }

        public void clear_list()
        {
            img_url_list.Clear();
            p_list.Clear();
            b_list.Clear();
            this.flowLayoutPanel1.Controls.Clear();
        }



        private void reset_thumbnails(object sender, System.EventArgs e)
        {
            clear_list();
            find_thumbnails(System.IO.Directory.GetCurrentDirectory());
            string[] names = img_url_list.ToArray();
            int med = names.Length / 2;
            flowLayoutPanel1.Show();

            Thread t1 = new Thread(() => {
                for (int i = 0; i < med; i++)
                {
                    useless(names, i);
                }
            });
            Thread t2 = new Thread(() => {
                for (int i = med; i < names.Length; i++)
                {
                    useless(names, i);
                }
            });
            t1.Start();
            t2.Start();
            string dir = System.IO.Directory.GetCurrentDirectory();
            this.treeView1.Nodes.Clear();
            show_directory_clean(dir, this.treeView1.Nodes);
        }

        private void search(object sender, System.EventArgs e)
        {
            clear_list();
            string name = textBox1.Text;
            find_thumbnails_detailed(System.IO.Directory.GetCurrentDirectory(), name);
            string[] names = img_url_list.ToArray();
            flowLayoutPanel1.Show();
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < names.Length; i++)
                {
                    useless(names, i);
                }
            });
            t1.Start();
        }

        public string find_path_from_tree(TreeNode tn)
        {
            //getting all the parents node to know which name we'll have to search afterward
            TreeNode temp = tn;
            List<string> l = new List<string>();
            string path = "";
            while (temp.Parent != null)
            {
                l.Add(temp.Parent.Text);
                temp = temp.Parent;
            }
            l.Reverse();
            foreach(string s in l)
            {
 
                path += "\\" + s;
            }
            path += "\\" + tn.Text;

            //searching the name in the directory_list
            //The first occurence will be the correct one
            foreach(string s in directory_list)
            {
                if (s.Contains(path))
                {
                    return s;
                }
            }
            return path;
        }

        private void search_from_tree(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeView1.Enabled = false;
            clear_list();
            find_thumbnails(find_path_from_tree(this.treeView1.SelectedNode));
            string[] names = img_url_list.ToArray();
            flowLayoutPanel1.Show();
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < names.Length; i++)
                {
                    useless(names, i);
                }
                MethodInvoker inv = delegate
                {
                    this.treeView1.Enabled = true;
                };
                this.Invoke(inv);
            });
            t1.Start();
        }

        public TextBox textBox1;
        public Button button1;
        public Button button2;
        public Button button3;

        private void on_insert(object sender, System.EventArgs e)
        {
            Form f = new Form2();
            f.ShowDialog();
            reset_thumbnails(sender,e);
            string dir = System.IO.Directory.GetCurrentDirectory();
            this.treeView1.Nodes.Clear();
            show_directory_clean(dir, this.treeView1.Nodes);
        }

        private Panel panel1;
        private Panel panel2;
    }
}


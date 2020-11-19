using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PBR_Showroom
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 298);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thumbnail file";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Files";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(202, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 13);
            this.textBox3.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(202, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 31);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(202, 105);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(289, 96);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(416, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.confirm);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Find file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.open_explorer_thumbnail);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Find files";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.open_explorer_files);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 298);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(805, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Material import";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public TextBox textBox3;
        public RichTextBox richTextBox1;
        public RichTextBox richTextBox2;
        public List<string> filelist = new List<string>();
        public string file_path = "";
        public List<string> directory_list = new List<string>();
        public string thumbnail_path;

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

        public void startup()
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            show_directory_clean(dir, this.treeView1.Nodes);
            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(dragEnter_thumbnail);
            richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(dragDrop_thumbnail);
            richTextBox2.AllowDrop = true;
            richTextBox2.DragEnter += new System.Windows.Forms.DragEventHandler(dragEnter);
            richTextBox2.DragDrop += new System.Windows.Forms.DragEventHandler(dragDrop);
        }

        private void dragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                filelist.Add(s[i]);
                richTextBox2.AppendText(Path.GetFileName(s[i]) + '\n');
            }
        }

        private void dragEnter_thumbnail(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dragDrop_thumbnail(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string file = s[0];
            richTextBox1.AppendText(Path.GetFileName(s[0]));
            thumbnail_path = s[0];
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
            foreach (string s in l)
            {

                path += "\\" + s;
            }
            path += "\\" + tn.Text;

            //searching the name in the directory_list
            //The first occurence will be the correct one
            foreach (string s in directory_list)
            {
                if (s.Contains(path))
                {
                    return s;
                }
            }
            return path;
        }

        public Button button1;

        public void confirm(object sender, System.EventArgs e)
        {
            string path_to_copy = find_path_from_tree(this.treeView1.SelectedNode);
            string name = this.textBox3.Text;
            name = name.Replace(' ','_');
            Console.WriteLine(path_to_copy);
            Console.WriteLine(name);
            string new_directory_name = path_to_copy + "\\" + name + "_library";
            Directory.CreateDirectory(new_directory_name);
            //filelist, thumbnail_path
            foreach (string s in filelist)
            {
                File.Copy(s, new_directory_name + "\\" + Path.GetFileName(s));
            }
            File.Copy(thumbnail_path, new_directory_name + "\\" + name + "_thumbnail" + Path.GetExtension(thumbnail_path));
            this.Close();
        }

        private Button button2;
        private Button button3;

        public void open_explorer_thumbnail(object sender, System.EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                thumbnail_path = fdlg.FileName;
                richTextBox1.AppendText(Path.GetFileName(thumbnail_path));
            }
        }

        public void open_explorer_files(object sender, System.EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            fdlg.Multiselect = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in fdlg.FileNames)
                {
                    filelist.Add(file);
                    richTextBox2.AppendText(Path.GetFileName(file) + '\n');
                }
            }
        }

        private Panel panel1;
    }
}
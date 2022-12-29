namespace ce205_hw4_duygu_ozturk
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NeedlemanRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NeedlemanTextBox2 = new System.Windows.Forms.TextBox();
            this.AlignmentNeedleman = new System.Windows.Forms.Button();
            this.NeedlemanTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SmithrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SmithtextBox2 = new System.Windows.Forms.TextBox();
            this.SmithAlignment = new System.Windows.Forms.Button();
            this.SmithtextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HuntrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HunttextBox2 = new System.Windows.Forms.TextBox();
            this.HuntAlignment = new System.Windows.Forms.Button();
            this.HunttextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.KnuthrichTextBox = new System.Windows.Forms.RichTextBox();
            this.KnuthtextBox = new System.Windows.Forms.TextBox();
            this.SearchKnuth = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.HorspoolrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HorspooltextBox = new System.Windows.Forms.TextBox();
            this.SearchHorspool = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BoyerrichTextBox = new System.Windows.Forms.RichTextBox();
            this.BoyertextBox = new System.Windows.Forms.TextBox();
            this.SearchBoyer = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InsertTrie = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SearchTrie = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.randomNW = new System.Windows.Forms.Button();
            this.randomNW1 = new System.Windows.Forms.Button();
            this.randomSW = new System.Windows.Forms.Button();
            this.randomSW1 = new System.Windows.Forms.Button();
            this.randomHS1 = new System.Windows.Forms.Button();
            this.randomHS = new System.Windows.Forms.Button();
            this.randomT = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1302, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.randomNW1);
            this.tabPage1.Controls.Add(this.randomNW);
            this.tabPage1.Controls.Add(this.NeedlemanRichTextBox);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox2);
            this.tabPage1.Controls.Add(this.AlignmentNeedleman);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1294, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Needleman-Wunsch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NeedlemanRichTextBox
            // 
            this.NeedlemanRichTextBox.Location = new System.Drawing.Point(339, 6);
            this.NeedlemanRichTextBox.Name = "NeedlemanRichTextBox";
            this.NeedlemanRichTextBox.Size = new System.Drawing.Size(844, 517);
            this.NeedlemanRichTextBox.TabIndex = 3;
            this.NeedlemanRichTextBox.Text = "";
            this.NeedlemanRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // NeedlemanTextBox2
            // 
            this.NeedlemanTextBox2.Location = new System.Drawing.Point(18, 238);
            this.NeedlemanTextBox2.Name = "NeedlemanTextBox2";
            this.NeedlemanTextBox2.Size = new System.Drawing.Size(295, 22);
            this.NeedlemanTextBox2.TabIndex = 2;
            this.NeedlemanTextBox2.TextChanged += new System.EventHandler(this.NeedlemanTextBox2_TextChanged);
            // 
            // AlignmentNeedleman
            // 
            this.AlignmentNeedleman.Location = new System.Drawing.Point(91, 362);
            this.AlignmentNeedleman.Name = "AlignmentNeedleman";
            this.AlignmentNeedleman.Size = new System.Drawing.Size(149, 66);
            this.AlignmentNeedleman.TabIndex = 1;
            this.AlignmentNeedleman.Text = "Alignment";
            this.AlignmentNeedleman.UseVisualStyleBackColor = true;
            this.AlignmentNeedleman.Click += new System.EventHandler(this.button1_Click);
            // 
            // NeedlemanTextBox1
            // 
            this.NeedlemanTextBox1.Location = new System.Drawing.Point(18, 171);
            this.NeedlemanTextBox1.Name = "NeedlemanTextBox1";
            this.NeedlemanTextBox1.Size = new System.Drawing.Size(295, 22);
            this.NeedlemanTextBox1.TabIndex = 0;
            this.NeedlemanTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.randomSW1);
            this.tabPage2.Controls.Add(this.randomSW);
            this.tabPage2.Controls.Add(this.SmithrichTextBox);
            this.tabPage2.Controls.Add(this.SmithtextBox2);
            this.tabPage2.Controls.Add(this.SmithAlignment);
            this.tabPage2.Controls.Add(this.SmithtextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1294, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smith-Waterman";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SmithrichTextBox
            // 
            this.SmithrichTextBox.Location = new System.Drawing.Point(326, 6);
            this.SmithrichTextBox.Name = "SmithrichTextBox";
            this.SmithrichTextBox.Size = new System.Drawing.Size(851, 520);
            this.SmithrichTextBox.TabIndex = 7;
            this.SmithrichTextBox.Text = "";
            // 
            // SmithtextBox2
            // 
            this.SmithtextBox2.Location = new System.Drawing.Point(26, 283);
            this.SmithtextBox2.Name = "SmithtextBox2";
            this.SmithtextBox2.Size = new System.Drawing.Size(250, 22);
            this.SmithtextBox2.TabIndex = 6;
            // 
            // SmithAlignment
            // 
            this.SmithAlignment.Location = new System.Drawing.Point(89, 431);
            this.SmithAlignment.Name = "SmithAlignment";
            this.SmithAlignment.Size = new System.Drawing.Size(136, 53);
            this.SmithAlignment.TabIndex = 5;
            this.SmithAlignment.Text = "Alignment";
            this.SmithAlignment.UseVisualStyleBackColor = true;
            this.SmithAlignment.Click += new System.EventHandler(this.SmithAlignment_Click);
            // 
            // SmithtextBox1
            // 
            this.SmithtextBox1.Location = new System.Drawing.Point(26, 159);
            this.SmithtextBox1.Name = "SmithtextBox1";
            this.SmithtextBox1.Size = new System.Drawing.Size(250, 22);
            this.SmithtextBox1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.randomHS);
            this.tabPage3.Controls.Add(this.randomHS1);
            this.tabPage3.Controls.Add(this.HuntrichTextBox);
            this.tabPage3.Controls.Add(this.HunttextBox2);
            this.tabPage3.Controls.Add(this.HuntAlignment);
            this.tabPage3.Controls.Add(this.HunttextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1294, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hunt-Szymanski";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HuntrichTextBox
            // 
            this.HuntrichTextBox.Location = new System.Drawing.Point(295, 18);
            this.HuntrichTextBox.Name = "HuntrichTextBox";
            this.HuntrichTextBox.Size = new System.Drawing.Size(886, 512);
            this.HuntrichTextBox.TabIndex = 7;
            this.HuntrichTextBox.Text = "";
            // 
            // HunttextBox2
            // 
            this.HunttextBox2.Location = new System.Drawing.Point(26, 298);
            this.HunttextBox2.Name = "HunttextBox2";
            this.HunttextBox2.Size = new System.Drawing.Size(244, 22);
            this.HunttextBox2.TabIndex = 6;
            // 
            // HuntAlignment
            // 
            this.HuntAlignment.Location = new System.Drawing.Point(80, 441);
            this.HuntAlignment.Name = "HuntAlignment";
            this.HuntAlignment.Size = new System.Drawing.Size(136, 48);
            this.HuntAlignment.TabIndex = 5;
            this.HuntAlignment.Text = "Alignment";
            this.HuntAlignment.UseVisualStyleBackColor = true;
            this.HuntAlignment.Click += new System.EventHandler(this.HuntAlignment_Click);
            // 
            // HunttextBox1
            // 
            this.HunttextBox1.Location = new System.Drawing.Point(26, 169);
            this.HunttextBox1.Name = "HunttextBox1";
            this.HunttextBox1.Size = new System.Drawing.Size(244, 22);
            this.HunttextBox1.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.KnuthrichTextBox);
            this.tabPage4.Controls.Add(this.KnuthtextBox);
            this.tabPage4.Controls.Add(this.SearchKnuth);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1294, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Knuth-Morris-Pratt";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // KnuthrichTextBox
            // 
            this.KnuthrichTextBox.Location = new System.Drawing.Point(283, 20);
            this.KnuthrichTextBox.Name = "KnuthrichTextBox";
            this.KnuthrichTextBox.Size = new System.Drawing.Size(902, 498);
            this.KnuthrichTextBox.TabIndex = 2;
            this.KnuthrichTextBox.Text = "";
            // 
            // KnuthtextBox
            // 
            this.KnuthtextBox.Location = new System.Drawing.Point(24, 226);
            this.KnuthtextBox.Name = "KnuthtextBox";
            this.KnuthtextBox.Size = new System.Drawing.Size(226, 22);
            this.KnuthtextBox.TabIndex = 1;
            this.KnuthtextBox.TextChanged += new System.EventHandler(this.KnuthtextBox_TextChanged);
            // 
            // SearchKnuth
            // 
            this.SearchKnuth.Location = new System.Drawing.Point(81, 276);
            this.SearchKnuth.Name = "SearchKnuth";
            this.SearchKnuth.Size = new System.Drawing.Size(110, 42);
            this.SearchKnuth.TabIndex = 0;
            this.SearchKnuth.Text = "Search";
            this.SearchKnuth.UseVisualStyleBackColor = true;
            this.SearchKnuth.Click += new System.EventHandler(this.SearchKnuth_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.HorspoolrichTextBox);
            this.tabPage5.Controls.Add(this.HorspooltextBox);
            this.tabPage5.Controls.Add(this.SearchHorspool);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1294, 564);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Horspool";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // HorspoolrichTextBox
            // 
            this.HorspoolrichTextBox.Location = new System.Drawing.Point(277, 19);
            this.HorspoolrichTextBox.Name = "HorspoolrichTextBox";
            this.HorspoolrichTextBox.Size = new System.Drawing.Size(905, 512);
            this.HorspoolrichTextBox.TabIndex = 5;
            this.HorspoolrichTextBox.Text = "";
            // 
            // HorspooltextBox
            // 
            this.HorspooltextBox.Location = new System.Drawing.Point(16, 253);
            this.HorspooltextBox.Name = "HorspooltextBox";
            this.HorspooltextBox.Size = new System.Drawing.Size(219, 22);
            this.HorspooltextBox.TabIndex = 4;
            // 
            // SearchHorspool
            // 
            this.SearchHorspool.Location = new System.Drawing.Point(66, 305);
            this.SearchHorspool.Name = "SearchHorspool";
            this.SearchHorspool.Size = new System.Drawing.Size(110, 42);
            this.SearchHorspool.TabIndex = 3;
            this.SearchHorspool.Text = "Search";
            this.SearchHorspool.UseVisualStyleBackColor = true;
            this.SearchHorspool.Click += new System.EventHandler(this.SearchHorspool_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.BoyerrichTextBox);
            this.tabPage6.Controls.Add(this.BoyertextBox);
            this.tabPage6.Controls.Add(this.SearchBoyer);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1294, 564);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Boyer-Moore";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // BoyerrichTextBox
            // 
            this.BoyerrichTextBox.Location = new System.Drawing.Point(283, 16);
            this.BoyerrichTextBox.Name = "BoyerrichTextBox";
            this.BoyerrichTextBox.Size = new System.Drawing.Size(889, 509);
            this.BoyerrichTextBox.TabIndex = 5;
            this.BoyerrichTextBox.Text = "";
            // 
            // BoyertextBox
            // 
            this.BoyertextBox.Location = new System.Drawing.Point(6, 264);
            this.BoyertextBox.Name = "BoyertextBox";
            this.BoyertextBox.Size = new System.Drawing.Size(247, 22);
            this.BoyertextBox.TabIndex = 4;
            // 
            // SearchBoyer
            // 
            this.SearchBoyer.Location = new System.Drawing.Point(86, 305);
            this.SearchBoyer.Name = "SearchBoyer";
            this.SearchBoyer.Size = new System.Drawing.Size(110, 42);
            this.SearchBoyer.TabIndex = 3;
            this.SearchBoyer.Text = "Search";
            this.SearchBoyer.UseVisualStyleBackColor = true;
            this.SearchBoyer.Click += new System.EventHandler(this.SearchBoyer_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.randomT);
            this.tabPage7.Controls.Add(this.richTextBox1);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.InsertTrie);
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Controls.Add(this.SearchTrie);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1294, 564);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Trie";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(775, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 544);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 260);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // InsertTrie
            // 
            this.InsertTrie.ImageKey = "insert-memory-card (1).png";
            this.InsertTrie.Location = new System.Drawing.Point(86, 88);
            this.InsertTrie.Margin = new System.Windows.Forms.Padding(4);
            this.InsertTrie.Name = "InsertTrie";
            this.InsertTrie.Size = new System.Drawing.Size(113, 51);
            this.InsertTrie.TabIndex = 12;
            this.InsertTrie.Text = "Insert";
            this.InsertTrie.UseVisualStyleBackColor = true;
            this.InsertTrie.Click += new System.EventHandler(this.InsertTrie_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(296, 13);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(471, 544);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // SearchTrie
            // 
            this.SearchTrie.ImageKey = "searching-bar.png";
            this.SearchTrie.Location = new System.Drawing.Point(86, 202);
            this.SearchTrie.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTrie.Name = "SearchTrie";
            this.SearchTrie.Size = new System.Drawing.Size(113, 50);
            this.SearchTrie.TabIndex = 10;
            this.SearchTrie.Text = "Search";
            this.SearchTrie.UseVisualStyleBackColor = true;
            this.SearchTrie.Click += new System.EventHandler(this.SearchTrie_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 431);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // randomNW
            // 
            this.randomNW.Location = new System.Drawing.Point(91, 199);
            this.randomNW.Name = "randomNW";
            this.randomNW.Size = new System.Drawing.Size(136, 33);
            this.randomNW.TabIndex = 4;
            this.randomNW.Text = "Random";
            this.randomNW.UseVisualStyleBackColor = true;
            this.randomNW.Click += new System.EventHandler(this.randomNW_Click);
            // 
            // randomNW1
            // 
            this.randomNW1.Location = new System.Drawing.Point(91, 266);
            this.randomNW1.Name = "randomNW1";
            this.randomNW1.Size = new System.Drawing.Size(136, 33);
            this.randomNW1.TabIndex = 5;
            this.randomNW1.Text = "Random";
            this.randomNW1.UseVisualStyleBackColor = true;
            this.randomNW1.Click += new System.EventHandler(this.randomNW1_Click);
            // 
            // randomSW
            // 
            this.randomSW.Location = new System.Drawing.Point(89, 187);
            this.randomSW.Name = "randomSW";
            this.randomSW.Size = new System.Drawing.Size(136, 33);
            this.randomSW.TabIndex = 8;
            this.randomSW.Text = "Random";
            this.randomSW.UseVisualStyleBackColor = true;
            this.randomSW.Click += new System.EventHandler(this.randomSW_Click);
            // 
            // randomSW1
            // 
            this.randomSW1.Location = new System.Drawing.Point(89, 332);
            this.randomSW1.Name = "randomSW1";
            this.randomSW1.Size = new System.Drawing.Size(136, 33);
            this.randomSW1.TabIndex = 9;
            this.randomSW1.Text = "Random";
            this.randomSW1.UseVisualStyleBackColor = true;
            this.randomSW1.Click += new System.EventHandler(this.randomSW1_Click);
            // 
            // randomHS1
            // 
            this.randomHS1.Location = new System.Drawing.Point(80, 326);
            this.randomHS1.Name = "randomHS1";
            this.randomHS1.Size = new System.Drawing.Size(136, 33);
            this.randomHS1.TabIndex = 9;
            this.randomHS1.Text = "Random";
            this.randomHS1.UseVisualStyleBackColor = true;
            this.randomHS1.Click += new System.EventHandler(this.button4_Click);
            // 
            // randomHS
            // 
            this.randomHS.Location = new System.Drawing.Point(80, 197);
            this.randomHS.Name = "randomHS";
            this.randomHS.Size = new System.Drawing.Size(136, 33);
            this.randomHS.TabIndex = 10;
            this.randomHS.Text = "Random";
            this.randomHS.UseVisualStyleBackColor = true;
            this.randomHS.Click += new System.EventHandler(this.button5_Click);
            // 
            // randomT
            // 
            this.randomT.ImageKey = "random.png";
            this.randomT.Location = new System.Drawing.Point(86, 373);
            this.randomT.Name = "randomT";
            this.randomT.Size = new System.Drawing.Size(113, 51);
            this.randomT.TabIndex = 15;
            this.randomT.Text = " Random";
            this.randomT.UseVisualStyleBackColor = true;
            this.randomT.Click += new System.EventHandler(this.randomT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox NeedlemanRichTextBox;
        private System.Windows.Forms.TextBox NeedlemanTextBox2;
        private System.Windows.Forms.Button AlignmentNeedleman;
        private System.Windows.Forms.TextBox NeedlemanTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox SmithrichTextBox;
        private System.Windows.Forms.TextBox SmithtextBox2;
        private System.Windows.Forms.Button SmithAlignment;
        private System.Windows.Forms.TextBox SmithtextBox1;
        private System.Windows.Forms.RichTextBox HuntrichTextBox;
        private System.Windows.Forms.TextBox HunttextBox2;
        private System.Windows.Forms.Button HuntAlignment;
        private System.Windows.Forms.TextBox HunttextBox1;
        private System.Windows.Forms.RichTextBox KnuthrichTextBox;
        private System.Windows.Forms.TextBox KnuthtextBox;
        private System.Windows.Forms.Button SearchKnuth;
        private System.Windows.Forms.RichTextBox HorspoolrichTextBox;
        private System.Windows.Forms.TextBox HorspooltextBox;
        private System.Windows.Forms.Button SearchHorspool;
        private System.Windows.Forms.RichTextBox BoyerrichTextBox;
        private System.Windows.Forms.TextBox BoyertextBox;
        private System.Windows.Forms.Button SearchBoyer;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button InsertTrie;
        public System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.Button SearchTrie;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button randomNW;
        private System.Windows.Forms.Button randomNW1;
        private System.Windows.Forms.Button randomSW1;
        private System.Windows.Forms.Button randomSW;
        private System.Windows.Forms.Button randomHS;
        private System.Windows.Forms.Button randomHS1;
        private System.Windows.Forms.Button randomT;
    }
}


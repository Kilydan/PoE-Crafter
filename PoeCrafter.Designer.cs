namespace WindowsFormsApplication1
{
    partial class PoeCrafter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoeCrafter));
            this.calculatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponCalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armorCraftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponCraftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeweleryCraftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WepCalc = new System.Windows.Forms.TabPage();
            this.WepBoxCalc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WepBox = new System.Windows.Forms.TextBox();
            this.WepCraft = new System.Windows.Forms.TabPage();
            this.ArmCalc = new System.Windows.Forms.TabPage();
            this.ArmCraft = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WepCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculatingToolStripMenuItem
            // 
            this.calculatingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weaponCalculationsToolStripMenuItem});
            this.calculatingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculatingToolStripMenuItem.Name = "calculatingToolStripMenuItem";
            this.calculatingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.calculatingToolStripMenuItem.Text = "Calculating";
            this.calculatingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculatingToolStripMenuItem.Click += new System.EventHandler(this.calculatingToolStripMenuItem_Click);
            // 
            // weaponCalculationsToolStripMenuItem
            // 
            this.weaponCalculationsToolStripMenuItem.Name = "weaponCalculationsToolStripMenuItem";
            this.weaponCalculationsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.weaponCalculationsToolStripMenuItem.Text = "Weapon Calculations";
            this.weaponCalculationsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // craftingToolStripMenuItem
            // 
            this.craftingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armorCraftingToolStripMenuItem,
            this.weaponCraftingToolStripMenuItem,
            this.jeweleryCraftingToolStripMenuItem});
            this.craftingToolStripMenuItem.Name = "craftingToolStripMenuItem";
            this.craftingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.craftingToolStripMenuItem.Text = "Crafting";
            this.craftingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // armorCraftingToolStripMenuItem
            // 
            this.armorCraftingToolStripMenuItem.Name = "armorCraftingToolStripMenuItem";
            this.armorCraftingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.armorCraftingToolStripMenuItem.Text = "Armor Crafting";
            // 
            // weaponCraftingToolStripMenuItem
            // 
            this.weaponCraftingToolStripMenuItem.Name = "weaponCraftingToolStripMenuItem";
            this.weaponCraftingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.weaponCraftingToolStripMenuItem.Text = "Weapon Crafting";
            // 
            // jeweleryCraftingToolStripMenuItem
            // 
            this.jeweleryCraftingToolStripMenuItem.Name = "jeweleryCraftingToolStripMenuItem";
            this.jeweleryCraftingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.jeweleryCraftingToolStripMenuItem.Text = "Jewelery Crafting";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatingToolStripMenuItem,
            this.craftingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WepCalc);
            this.tabControl1.Controls.Add(this.WepCraft);
            this.tabControl1.Controls.Add(this.ArmCalc);
            this.tabControl1.Controls.Add(this.ArmCraft);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 347);
            this.tabControl1.TabIndex = 6;
            // 
            // WepCalc
            // 
            this.WepCalc.Controls.Add(this.WepBoxCalc);
            this.WepCalc.Controls.Add(this.button1);
            this.WepCalc.Controls.Add(this.WepBox);
            this.WepCalc.Location = new System.Drawing.Point(4, 22);
            this.WepCalc.Name = "WepCalc";
            this.WepCalc.Size = new System.Drawing.Size(576, 321);
            this.WepCalc.TabIndex = 0;
            this.WepCalc.Text = "Weapon calculation";
            this.WepCalc.UseVisualStyleBackColor = true;
            // 
            // WepBoxCalc
            // 
            this.WepBoxCalc.BackColor = System.Drawing.Color.White;
            this.WepBoxCalc.Location = new System.Drawing.Point(333, 3);
            this.WepBoxCalc.Multiline = true;
            this.WepBoxCalc.Name = "WepBoxCalc";
            this.WepBoxCalc.Size = new System.Drawing.Size(236, 315);
            this.WepBoxCalc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(250, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WepBox
            // 
            this.WepBox.Location = new System.Drawing.Point(8, 3);
            this.WepBox.Multiline = true;
            this.WepBox.Name = "WepBox";
            this.WepBox.Size = new System.Drawing.Size(236, 315);
            this.WepBox.TabIndex = 0;
            // 
            // WepCraft
            // 
            this.WepCraft.Location = new System.Drawing.Point(4, 22);
            this.WepCraft.Name = "WepCraft";
            this.WepCraft.Size = new System.Drawing.Size(576, 321);
            this.WepCraft.TabIndex = 2;
            this.WepCraft.Text = "Weapon crafting";
            this.WepCraft.UseVisualStyleBackColor = true;
            // 
            // ArmCalc
            // 
            this.ArmCalc.Location = new System.Drawing.Point(4, 22);
            this.ArmCalc.Name = "ArmCalc";
            this.ArmCalc.Size = new System.Drawing.Size(576, 321);
            this.ArmCalc.TabIndex = 3;
            this.ArmCalc.Text = "Armor calculation";
            this.ArmCalc.UseVisualStyleBackColor = true;
            // 
            // ArmCraft
            // 
            this.ArmCraft.Location = new System.Drawing.Point(4, 22);
            this.ArmCraft.Name = "ArmCraft";
            this.ArmCraft.Size = new System.Drawing.Size(576, 321);
            this.ArmCraft.TabIndex = 4;
            this.ArmCraft.Text = "Armor Crafting";
            this.ArmCraft.UseVisualStyleBackColor = true;
            // 
            // PoeCrafter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PoeCrafter";
            this.Text = "PoE crafting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.WepCalc.ResumeLayout(false);
            this.WepCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem calculatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponCalculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem craftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armorCraftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponCraftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeweleryCraftingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WepCalc;
        private System.Windows.Forms.TextBox WepBoxCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WepBox;
        private System.Windows.Forms.TabPage WepCraft;
        private System.Windows.Forms.TabPage ArmCalc;
        private System.Windows.Forms.TabPage ArmCraft;
    }
}


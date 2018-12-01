namespace WillowTree
{
    partial class CharacterManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterManager));
            this.characterGrid = new System.Windows.Forms.DataGridView();
            this.characterNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // characterGrid
            // 
            this.characterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.characterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characterNames,
            this.characterClasses});
            this.characterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterGrid.Location = new System.Drawing.Point(0, 0);
            this.characterGrid.Name = "characterGrid";
            this.characterGrid.Size = new System.Drawing.Size(441, 220);
            this.characterGrid.TabIndex = 0;
            this.characterGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.characterGrid_UserAddedRow);
            this.characterGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.characterGrid_UserDeletingRow);
            // 
            // characterNames
            // 
            this.characterNames.HeaderText = "Character Name";
            this.characterNames.Name = "characterNames";
            this.characterNames.ToolTipText = "The name of your character, possibly the name of the class.";
            // 
            // characterClasses
            // 
            this.characterClasses.HeaderText = "Character Class";
            this.characterClasses.Name = "characterClasses";
            // 
            // CharacterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 220);
            this.Controls.Add(this.characterGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterManager";
            this.Text = "WillowTree - Character Manager";
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView characterGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterClasses;
    }
}
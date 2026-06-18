namespace Laboration4
{
    partial class Kassa
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
            this.Cartlist = new System.Windows.Forms.ListBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Cartlist
            // 
            this.Cartlist.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.Cartlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cartlist.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Cartlist.FormattingEnabled = true;
            this.Cartlist.ItemHeight = 24;
            this.Cartlist.Location = new System.Drawing.Point(260, 21);
            this.Cartlist.Name = "Cartlist";
            this.Cartlist.Size = new System.Drawing.Size(748, 268);
            this.Cartlist.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmButton.Location = new System.Drawing.Point(9, 171);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(207, 48);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "CheckOut";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(9, 90);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(210, 41);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "RemoveFromCart";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(12, 21);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(207, 41);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "AddToCart";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            this.ProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(1, 291);
            this.ProductDataGrid.MultiSelect = false;
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowTemplate.Height = 31;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.ShowCellErrors = false;
            this.ProductDataGrid.ShowCellToolTips = false;
            this.ProductDataGrid.ShowEditingIcon = false;
            this.ProductDataGrid.ShowRowErrors = false;
            this.ProductDataGrid.Size = new System.Drawing.Size(1007, 271);
            this.ProductDataGrid.TabIndex = 9;
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 568);
            this.Controls.Add(this.ProductDataGrid);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Cartlist);
            this.Name = "Kassa";
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.Kassa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Cartlist;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataGridView ProductDataGrid;
    }
}
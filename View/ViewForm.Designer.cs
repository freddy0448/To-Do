namespace View
{
    partial class ViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTopLabel = new System.Windows.Forms.Label();
            this.pctrbAdd = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pctrbEdit = new System.Windows.Forms.PictureBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pctrbDelete = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.dgvToDo = new System.Windows.Forms.DataGridView();
            this.dgvEventCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHourCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddressCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblTopLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 109);
            this.panel1.TabIndex = 0;
            // 
            // lblTopLabel
            // 
            this.lblTopLabel.AutoSize = true;
            this.lblTopLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopLabel.Location = new System.Drawing.Point(651, 32);
            this.lblTopLabel.Name = "lblTopLabel";
            this.lblTopLabel.Size = new System.Drawing.Size(142, 38);
            this.lblTopLabel.TabIndex = 0;
            this.lblTopLabel.Text = "To do List";
            // 
            // pctrbAdd
            // 
            this.pctrbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrbAdd.Image = global::View.Properties.Resources.agregar;
            this.pctrbAdd.Location = new System.Drawing.Point(22, 127);
            this.pctrbAdd.Name = "pctrbAdd";
            this.pctrbAdd.Size = new System.Drawing.Size(150, 150);
            this.pctrbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrbAdd.TabIndex = 1;
            this.pctrbAdd.TabStop = false;
            this.pctrbAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.Location = new System.Drawing.Point(36, 282);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(123, 38);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Agregar";
            // 
            // pctrbEdit
            // 
            this.pctrbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrbEdit.Image = global::View.Properties.Resources.editar;
            this.pctrbEdit.Location = new System.Drawing.Point(22, 325);
            this.pctrbEdit.Name = "pctrbEdit";
            this.pctrbEdit.Size = new System.Drawing.Size(150, 150);
            this.pctrbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrbEdit.TabIndex = 3;
            this.pctrbEdit.TabStop = false;
            this.pctrbEdit.Click += new System.EventHandler(this.pctrbEdit_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.Location = new System.Drawing.Point(50, 480);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(94, 38);
            this.lblEdit.TabIndex = 4;
            this.lblEdit.Text = "Editar";
            // 
            // pctrbDelete
            // 
            this.pctrbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrbDelete.Image = global::View.Properties.Resources.expediente;
            this.pctrbDelete.Location = new System.Drawing.Point(22, 523);
            this.pctrbDelete.Name = "pctrbDelete";
            this.pctrbDelete.Size = new System.Drawing.Size(150, 150);
            this.pctrbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrbDelete.TabIndex = 5;
            this.pctrbDelete.TabStop = false;
            this.pctrbDelete.Click += new System.EventHandler(this.pctrbDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDelete.Location = new System.Drawing.Point(35, 678);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(125, 38);
            this.lblDelete.TabIndex = 6;
            this.lblDelete.Text = "Eliminar";
            // 
            // dgvToDo
            // 
            this.dgvToDo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEventCL,
            this.dgvDateCL,
            this.dgvHourCL,
            this.dgvAddressCL});
            this.dgvToDo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvToDo.Location = new System.Drawing.Point(810, 127);
            this.dgvToDo.Name = "dgvToDo";
            this.dgvToDo.ReadOnly = true;
            this.dgvToDo.RowHeadersWidth = 51;
            this.dgvToDo.RowTemplate.Height = 29;
            this.dgvToDo.Size = new System.Drawing.Size(562, 546);
            this.dgvToDo.TabIndex = 7;
            this.dgvToDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToDo_CellClick);
            
            // 
            // dgvEventCL
            // 
            this.dgvEventCL.HeaderText = "Evento";
            this.dgvEventCL.MinimumWidth = 6;
            this.dgvEventCL.Name = "dgvEventCL";
            this.dgvEventCL.ReadOnly = true;
            this.dgvEventCL.Width = 125;
            // 
            // dgvDateCL
            // 
            this.dgvDateCL.HeaderText = "Fecha";
            this.dgvDateCL.MinimumWidth = 6;
            this.dgvDateCL.Name = "dgvDateCL";
            this.dgvDateCL.ReadOnly = true;
            this.dgvDateCL.Width = 125;
            // 
            // dgvHourCL
            // 
            this.dgvHourCL.HeaderText = "Hora";
            this.dgvHourCL.MinimumWidth = 6;
            this.dgvHourCL.Name = "dgvHourCL";
            this.dgvHourCL.ReadOnly = true;
            this.dgvHourCL.Width = 125;
            // 
            // dgvAddressCL
            // 
            this.dgvAddressCL.HeaderText = "Direccion";
            this.dgvAddressCL.MinimumWidth = 6;
            this.dgvAddressCL.Name = "dgvAddressCL";
            this.dgvAddressCL.ReadOnly = true;
            this.dgvAddressCL.Width = 125;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(275, 321);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 38);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Fecha";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(281, 441);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(81, 38);
            this.lblHour.TabIndex = 9;
            this.lblHour.Text = "Hora";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(251, 561);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(140, 38);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Direccion";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEvent.Location = new System.Drawing.Point(268, 201);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(107, 38);
            this.lblEvent.TabIndex = 14;
            this.lblEvent.Text = "Evento";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(410, 212);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(298, 27);
            this.txtEvent.TabIndex = 15;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(410, 332);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(298, 27);
            this.txtDate.TabIndex = 16;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(410, 452);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(298, 27);
            this.txtHour.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(410, 572);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 27);
            this.txtAddress.TabIndex = 18;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1404, 726);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvToDo);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.pctrbDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.pctrbEdit);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.pctrbAdd);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ViewForm";
            this.Text = "To do list.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblTopLabel;
        private PictureBox pctrbAdd;
        private Label lblAdd;
        private PictureBox pctrbEdit;
        private Label lblEdit;
        private PictureBox pctrbDelete;
        private Label lblDelete;
        private DataGridView dgvToDo;
        private Label lblDate;
        private Label lblHour;
        private Label lblAddress;
        private Label lblEvent;
        private TextBox txtEvent;
        private TextBox txtDate;
        private TextBox txtHour;
        private TextBox txtAddress;
        private DataGridViewTextBoxColumn dgvEventCL;
        private DataGridViewTextBoxColumn dgvDateCL;
        private DataGridViewTextBoxColumn dgvHourCL;
        private DataGridViewTextBoxColumn dgvAddressCL;
    }
}
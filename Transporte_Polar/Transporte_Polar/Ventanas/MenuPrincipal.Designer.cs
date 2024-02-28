namespace Transporte_Polar.Ventanas
{
    partial class MenuPrincipal
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
            System.Windows.Forms.TabControl tabControlRegistrarCamion;
            this.tabPageRegistrarCamion = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCedulaChofer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlacaCamion = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonActualizarCamion = new System.Windows.Forms.Button();
            this.buttonBuscarCamion = new System.Windows.Forms.Button();
            this.buttonIncluirCamion = new System.Windows.Forms.Button();
            this.tabPageRegistrarViajes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPagado = new System.Windows.Forms.RadioButton();
            this.radioButtonRealizado = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCodigoViaje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumeroGuia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonIncluirViajes = new System.Windows.Forms.Button();
            this.tabPageRegistrarCodigo = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoViaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDestinos = new System.Windows.Forms.TextBox();
            this.buttonClearCodigo = new System.Windows.Forms.Button();
            this.buttonActualizarCodigo = new System.Windows.Forms.Button();
            this.buttonBuscarCodigo = new System.Windows.Forms.Button();
            this.buttonIncluirCodigo = new System.Windows.Forms.Button();
            this.tabPageReportePagos = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigoDelViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadViajesCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabControlRegistrarCamion = new System.Windows.Forms.TabControl();
            tabControlRegistrarCamion.SuspendLayout();
            this.tabPageRegistrarCamion.SuspendLayout();
            this.tabPageRegistrarViajes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageRegistrarCodigo.SuspendLayout();
            this.tabPageReportePagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRegistrarCamion
            // 
            tabControlRegistrarCamion.Controls.Add(this.tabPageRegistrarCamion);
            tabControlRegistrarCamion.Controls.Add(this.tabPageRegistrarViajes);
            tabControlRegistrarCamion.Controls.Add(this.tabPageRegistrarCodigo);
            tabControlRegistrarCamion.Controls.Add(this.tabPageReportePagos);
            tabControlRegistrarCamion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabControlRegistrarCamion.ItemSize = new System.Drawing.Size(81, 46);
            tabControlRegistrarCamion.Location = new System.Drawing.Point(2, 2);
            tabControlRegistrarCamion.Name = "tabControlRegistrarCamion";
            tabControlRegistrarCamion.SelectedIndex = 0;
            tabControlRegistrarCamion.Size = new System.Drawing.Size(798, 446);
            tabControlRegistrarCamion.TabIndex = 0;
            // 
            // tabPageRegistrarCamion
            // 
            this.tabPageRegistrarCamion.AccessibleDescription = "RegistrarCamion";
            this.tabPageRegistrarCamion.AccessibleName = "RegistrarCamion";
            this.tabPageRegistrarCamion.BackColor = System.Drawing.Color.Navy;
            this.tabPageRegistrarCamion.Controls.Add(this.label2);
            this.tabPageRegistrarCamion.Controls.Add(this.textBoxCedulaChofer);
            this.tabPageRegistrarCamion.Controls.Add(this.label1);
            this.tabPageRegistrarCamion.Controls.Add(this.textBoxPlacaCamion);
            this.tabPageRegistrarCamion.Controls.Add(this.buttonClear);
            this.tabPageRegistrarCamion.Controls.Add(this.buttonActualizarCamion);
            this.tabPageRegistrarCamion.Controls.Add(this.buttonBuscarCamion);
            this.tabPageRegistrarCamion.Controls.Add(this.buttonIncluirCamion);
            this.tabPageRegistrarCamion.Location = new System.Drawing.Point(4, 50);
            this.tabPageRegistrarCamion.Name = "tabPageRegistrarCamion";
            this.tabPageRegistrarCamion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarCamion.Size = new System.Drawing.Size(790, 392);
            this.tabPageRegistrarCamion.TabIndex = 0;
            this.tabPageRegistrarCamion.Text = "Registrar camion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(203, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula Chofer";
            // 
            // textBoxCedulaChofer
            // 
            this.textBoxCedulaChofer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCedulaChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCedulaChofer.Location = new System.Drawing.Point(192, 129);
            this.textBoxCedulaChofer.Name = "textBoxCedulaChofer";
            this.textBoxCedulaChofer.Size = new System.Drawing.Size(213, 28);
            this.textBoxCedulaChofer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(184, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa Del Camion";
            // 
            // textBoxPlacaCamion
            // 
            this.textBoxPlacaCamion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPlacaCamion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlacaCamion.Location = new System.Drawing.Point(190, 244);
            this.textBoxPlacaCamion.Name = "textBoxPlacaCamion";
            this.textBoxPlacaCamion.Size = new System.Drawing.Size(213, 28);
            this.textBoxPlacaCamion.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(549, 254);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(233, 70);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonActualizarCamion
            // 
            this.buttonActualizarCamion.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarCamion.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCamion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonActualizarCamion.Location = new System.Drawing.Point(549, 187);
            this.buttonActualizarCamion.Name = "buttonActualizarCamion";
            this.buttonActualizarCamion.Size = new System.Drawing.Size(233, 70);
            this.buttonActualizarCamion.TabIndex = 2;
            this.buttonActualizarCamion.Text = "Actualizar";
            this.buttonActualizarCamion.UseVisualStyleBackColor = false;
            this.buttonActualizarCamion.Click += new System.EventHandler(this.buttonActualizarCamion_Click);
            // 
            // buttonBuscarCamion
            // 
            this.buttonBuscarCamion.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBuscarCamion.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonBuscarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCamion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscarCamion.Location = new System.Drawing.Point(549, 120);
            this.buttonBuscarCamion.Name = "buttonBuscarCamion";
            this.buttonBuscarCamion.Size = new System.Drawing.Size(233, 70);
            this.buttonBuscarCamion.TabIndex = 1;
            this.buttonBuscarCamion.Text = "Buscar";
            this.buttonBuscarCamion.UseVisualStyleBackColor = false;
            this.buttonBuscarCamion.Click += new System.EventHandler(this.buttonBuscarCamion_Click);
            // 
            // buttonIncluirCamion
            // 
            this.buttonIncluirCamion.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonIncluirCamion.FlatAppearance.BorderSize = 0;
            this.buttonIncluirCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonIncluirCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncluirCamion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIncluirCamion.Location = new System.Drawing.Point(549, 56);
            this.buttonIncluirCamion.Name = "buttonIncluirCamion";
            this.buttonIncluirCamion.Size = new System.Drawing.Size(233, 70);
            this.buttonIncluirCamion.TabIndex = 0;
            this.buttonIncluirCamion.Text = "Incluir";
            this.buttonIncluirCamion.UseVisualStyleBackColor = false;
            this.buttonIncluirCamion.Click += new System.EventHandler(this.buttonIncluirCamion_Click);
            // 
            // tabPageRegistrarViajes
            // 
            this.tabPageRegistrarViajes.AccessibleDescription = "Registrar Viajes";
            this.tabPageRegistrarViajes.AccessibleName = "Registrar Viajes";
            this.tabPageRegistrarViajes.BackColor = System.Drawing.Color.Navy;
            this.tabPageRegistrarViajes.Controls.Add(this.groupBox1);
            this.tabPageRegistrarViajes.Controls.Add(this.label5);
            this.tabPageRegistrarViajes.Controls.Add(this.comboBoxCodigoViaje);
            this.tabPageRegistrarViajes.Controls.Add(this.label3);
            this.tabPageRegistrarViajes.Controls.Add(this.label4);
            this.tabPageRegistrarViajes.Controls.Add(this.textBoxNumeroGuia);
            this.tabPageRegistrarViajes.Controls.Add(this.button1);
            this.tabPageRegistrarViajes.Controls.Add(this.button2);
            this.tabPageRegistrarViajes.Controls.Add(this.button3);
            this.tabPageRegistrarViajes.Controls.Add(this.buttonIncluirViajes);
            this.tabPageRegistrarViajes.Location = new System.Drawing.Point(4, 50);
            this.tabPageRegistrarViajes.Name = "tabPageRegistrarViajes";
            this.tabPageRegistrarViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarViajes.Size = new System.Drawing.Size(790, 392);
            this.tabPageRegistrarViajes.TabIndex = 1;
            this.tabPageRegistrarViajes.Text = "Registrar Viajes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPagado);
            this.groupBox1.Controls.Add(this.radioButtonRealizado);
            this.groupBox1.Location = new System.Drawing.Point(139, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 122);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonPagado
            // 
            this.radioButtonPagado.AutoSize = true;
            this.radioButtonPagado.Location = new System.Drawing.Point(74, 65);
            this.radioButtonPagado.Name = "radioButtonPagado";
            this.radioButtonPagado.Size = new System.Drawing.Size(85, 25);
            this.radioButtonPagado.TabIndex = 1;
            this.radioButtonPagado.TabStop = true;
            this.radioButtonPagado.Text = "Pagado";
            this.radioButtonPagado.UseVisualStyleBackColor = true;
            // 
            // radioButtonRealizado
            // 
            this.radioButtonRealizado.AutoSize = true;
            this.radioButtonRealizado.FlatAppearance.BorderSize = 0;
            this.radioButtonRealizado.Location = new System.Drawing.Point(74, 34);
            this.radioButtonRealizado.Name = "radioButtonRealizado";
            this.radioButtonRealizado.Size = new System.Drawing.Size(103, 25);
            this.radioButtonRealizado.TabIndex = 0;
            this.radioButtonRealizado.TabStop = true;
            this.radioButtonRealizado.Text = "Realizado";
            this.radioButtonRealizado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(152, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado del Viaje";
            // 
            // comboBoxCodigoViaje
            // 
            this.comboBoxCodigoViaje.FormattingEnabled = true;
            this.comboBoxCodigoViaje.Location = new System.Drawing.Point(157, 74);
            this.comboBoxCodigoViaje.Name = "comboBoxCodigoViaje";
            this.comboBoxCodigoViaje.Size = new System.Drawing.Size(219, 29);
            this.comboBoxCodigoViaje.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(160, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo del viaje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(151, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numero de Guia";
            // 
            // textBoxNumeroGuia
            // 
            this.textBoxNumeroGuia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumeroGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeroGuia.Location = new System.Drawing.Point(157, 148);
            this.textBoxNumeroGuia.Name = "textBoxNumeroGuia";
            this.textBoxNumeroGuia.Size = new System.Drawing.Size(213, 28);
            this.textBoxNumeroGuia.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(545, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(545, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 70);
            this.button2.TabIndex = 10;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(545, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonIncluirViajes
            // 
            this.buttonIncluirViajes.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonIncluirViajes.FlatAppearance.BorderSize = 0;
            this.buttonIncluirViajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonIncluirViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncluirViajes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIncluirViajes.Location = new System.Drawing.Point(545, 51);
            this.buttonIncluirViajes.Name = "buttonIncluirViajes";
            this.buttonIncluirViajes.Size = new System.Drawing.Size(233, 70);
            this.buttonIncluirViajes.TabIndex = 8;
            this.buttonIncluirViajes.Text = "Incluir";
            this.buttonIncluirViajes.UseVisualStyleBackColor = false;
            // 
            // tabPageRegistrarCodigo
            // 
            this.tabPageRegistrarCodigo.AccessibleDescription = "Registrar Codigo";
            this.tabPageRegistrarCodigo.AccessibleName = "Registrar Codigo";
            this.tabPageRegistrarCodigo.BackColor = System.Drawing.Color.Navy;
            this.tabPageRegistrarCodigo.Controls.Add(this.label8);
            this.tabPageRegistrarCodigo.Controls.Add(this.textBoxPrecio);
            this.tabPageRegistrarCodigo.Controls.Add(this.label6);
            this.tabPageRegistrarCodigo.Controls.Add(this.textBoxCodigoViaje);
            this.tabPageRegistrarCodigo.Controls.Add(this.label7);
            this.tabPageRegistrarCodigo.Controls.Add(this.textBoxDestinos);
            this.tabPageRegistrarCodigo.Controls.Add(this.buttonClearCodigo);
            this.tabPageRegistrarCodigo.Controls.Add(this.buttonActualizarCodigo);
            this.tabPageRegistrarCodigo.Controls.Add(this.buttonBuscarCodigo);
            this.tabPageRegistrarCodigo.Controls.Add(this.buttonIncluirCodigo);
            this.tabPageRegistrarCodigo.Location = new System.Drawing.Point(4, 50);
            this.tabPageRegistrarCodigo.Name = "tabPageRegistrarCodigo";
            this.tabPageRegistrarCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarCodigo.Size = new System.Drawing.Size(790, 392);
            this.tabPageRegistrarCodigo.TabIndex = 2;
            this.tabPageRegistrarCodigo.Text = "Registrar Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(161, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "Precio Viaje";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecio.Location = new System.Drawing.Point(129, 244);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(213, 28);
            this.textBoxPrecio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(129, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Codigo del Viaje";
            // 
            // textBoxCodigoViaje
            // 
            this.textBoxCodigoViaje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCodigoViaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigoViaje.Location = new System.Drawing.Point(129, 71);
            this.textBoxCodigoViaje.Name = "textBoxCodigoViaje";
            this.textBoxCodigoViaje.Size = new System.Drawing.Size(213, 28);
            this.textBoxCodigoViaje.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(129, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Destinos Viaje";
            // 
            // textBoxDestinos
            // 
            this.textBoxDestinos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDestinos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDestinos.Location = new System.Drawing.Point(129, 158);
            this.textBoxDestinos.Name = "textBoxDestinos";
            this.textBoxDestinos.Size = new System.Drawing.Size(213, 28);
            this.textBoxDestinos.TabIndex = 12;
            // 
            // buttonClearCodigo
            // 
            this.buttonClearCodigo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearCodigo.FlatAppearance.BorderSize = 0;
            this.buttonClearCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonClearCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearCodigo.Location = new System.Drawing.Point(549, 269);
            this.buttonClearCodigo.Name = "buttonClearCodigo";
            this.buttonClearCodigo.Size = new System.Drawing.Size(233, 70);
            this.buttonClearCodigo.TabIndex = 11;
            this.buttonClearCodigo.Text = "Clear";
            this.buttonClearCodigo.UseVisualStyleBackColor = false;
            this.buttonClearCodigo.Click += new System.EventHandler(this.buttonClearCodigo_Click);
            // 
            // buttonActualizarCodigo
            // 
            this.buttonActualizarCodigo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizarCodigo.FlatAppearance.BorderSize = 0;
            this.buttonActualizarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonActualizarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonActualizarCodigo.Location = new System.Drawing.Point(549, 202);
            this.buttonActualizarCodigo.Name = "buttonActualizarCodigo";
            this.buttonActualizarCodigo.Size = new System.Drawing.Size(233, 70);
            this.buttonActualizarCodigo.TabIndex = 10;
            this.buttonActualizarCodigo.Text = "Actualizar";
            this.buttonActualizarCodigo.UseVisualStyleBackColor = false;
            this.buttonActualizarCodigo.Click += new System.EventHandler(this.buttonActualizarCodigo_Click);
            // 
            // buttonBuscarCodigo
            // 
            this.buttonBuscarCodigo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBuscarCodigo.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonBuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscarCodigo.Location = new System.Drawing.Point(549, 135);
            this.buttonBuscarCodigo.Name = "buttonBuscarCodigo";
            this.buttonBuscarCodigo.Size = new System.Drawing.Size(233, 70);
            this.buttonBuscarCodigo.TabIndex = 9;
            this.buttonBuscarCodigo.Text = "Buscar";
            this.buttonBuscarCodigo.UseVisualStyleBackColor = false;
            this.buttonBuscarCodigo.Click += new System.EventHandler(this.buttonBuscarCodigo_Click);
            // 
            // buttonIncluirCodigo
            // 
            this.buttonIncluirCodigo.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonIncluirCodigo.FlatAppearance.BorderSize = 0;
            this.buttonIncluirCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonIncluirCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncluirCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIncluirCodigo.Location = new System.Drawing.Point(549, 71);
            this.buttonIncluirCodigo.Name = "buttonIncluirCodigo";
            this.buttonIncluirCodigo.Size = new System.Drawing.Size(233, 70);
            this.buttonIncluirCodigo.TabIndex = 8;
            this.buttonIncluirCodigo.Text = "Incluir";
            this.buttonIncluirCodigo.UseVisualStyleBackColor = false;
            this.buttonIncluirCodigo.Click += new System.EventHandler(this.buttonIncluirCodigo_Click);
            // 
            // tabPageReportePagos
            // 
            this.tabPageReportePagos.AccessibleDescription = "Reporte de Pagos";
            this.tabPageReportePagos.AccessibleName = "Reporte de Pagos";
            this.tabPageReportePagos.BackColor = System.Drawing.Color.Navy;
            this.tabPageReportePagos.Controls.Add(this.label9);
            this.tabPageReportePagos.Controls.Add(this.textBoxSearch);
            this.tabPageReportePagos.Controls.Add(this.dataGridView1);
            this.tabPageReportePagos.Location = new System.Drawing.Point(4, 50);
            this.tabPageReportePagos.Name = "tabPageReportePagos";
            this.tabPageReportePagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportePagos.Size = new System.Drawing.Size(790, 392);
            this.tabPageReportePagos.TabIndex = 3;
            this.tabPageReportePagos.Text = "Reporte de Pagos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(18, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(448, 34);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cedula Chofer o Placa Del Camion:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(483, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 28);
            this.textBoxSearch.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCedula,
            this.ColumnCodigoDelViaje,
            this.ColumnCantidadViajesCodigo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnCedula
            // 
            this.ColumnCedula.HeaderText = "Cedula del Chofer";
            this.ColumnCedula.MinimumWidth = 6;
            this.ColumnCedula.Name = "ColumnCedula";
            this.ColumnCedula.Width = 125;
            // 
            // ColumnCodigoDelViaje
            // 
            this.ColumnCodigoDelViaje.HeaderText = "Codigo del viaje";
            this.ColumnCodigoDelViaje.MinimumWidth = 6;
            this.ColumnCodigoDelViaje.Name = "ColumnCodigoDelViaje";
            this.ColumnCodigoDelViaje.Width = 125;
            // 
            // ColumnCantidadViajesCodigo
            // 
            this.ColumnCantidadViajesCodigo.HeaderText = "Cantidad Viajes por Codigo";
            this.ColumnCantidadViajesCodigo.MinimumWidth = 6;
            this.ColumnCantidadViajesCodigo.Name = "ColumnCantidadViajesCodigo";
            this.ColumnCantidadViajesCodigo.Width = 125;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tabControlRegistrarCamion);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            tabControlRegistrarCamion.ResumeLayout(false);
            this.tabPageRegistrarCamion.ResumeLayout(false);
            this.tabPageRegistrarCamion.PerformLayout();
            this.tabPageRegistrarViajes.ResumeLayout(false);
            this.tabPageRegistrarViajes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageRegistrarCodigo.ResumeLayout(false);
            this.tabPageRegistrarCodigo.PerformLayout();
            this.tabPageReportePagos.ResumeLayout(false);
            this.tabPageReportePagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageRegistrarCamion;
        private System.Windows.Forms.TabPage tabPageRegistrarViajes;
        private System.Windows.Forms.TabPage tabPageRegistrarCodigo;
        private System.Windows.Forms.TabPage tabPageReportePagos;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonActualizarCamion;
        private System.Windows.Forms.Button buttonBuscarCamion;
        private System.Windows.Forms.Button buttonIncluirCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCedulaChofer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlacaCamion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCodigoViaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumeroGuia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonIncluirViajes;
        private System.Windows.Forms.RadioButton radioButtonPagado;
        private System.Windows.Forms.RadioButton radioButtonRealizado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigoViaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDestinos;
        private System.Windows.Forms.Button buttonClearCodigo;
        private System.Windows.Forms.Button buttonActualizarCodigo;
        private System.Windows.Forms.Button buttonBuscarCodigo;
        private System.Windows.Forms.Button buttonIncluirCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoDelViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadViajesCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}
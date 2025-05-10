namespace ConsumodeAPIs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            picPokemon = new PictureBox();
            lblNombre = new Label();
            lblStats = new Label();
            btnChuckNorris = new Button();
            lblChuck = new Label();
            picChuck = new PictureBox();
            btnLimpiar = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChuck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(100, 118);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CornflowerBlue;
            btnBuscar.Location = new Point(84, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 24);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Pokemon";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // picPokemon
            // 
            picPokemon.BackColor = SystemColors.ActiveCaption;
            picPokemon.Location = new Point(84, 283);
            picPokemon.Name = "picPokemon";
            picPokemon.Size = new Size(88, 71);
            picPokemon.TabIndex = 3;
            picPokemon.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 203);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 4;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(232, 203);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(0, 15);
            lblStats.TabIndex = 5;
            // 
            // btnChuckNorris
            // 
            btnChuckNorris.BackColor = Color.DarkOrange;
            btnChuckNorris.Location = new Point(578, 47);
            btnChuckNorris.Name = "btnChuckNorris";
            btnChuckNorris.Size = new Size(276, 23);
            btnChuckNorris.TabIndex = 6;
            btnChuckNorris.Text = "Presione para palabra random de Chuck Norris";
            btnChuckNorris.UseVisualStyleBackColor = false;
            btnChuckNorris.Click += btnChuckNorris_Click;
            // 
            // lblChuck
            // 
            lblChuck.AutoSize = true;
            lblChuck.Location = new Point(459, 136);
            lblChuck.Name = "lblChuck";
            lblChuck.Size = new Size(0, 15);
            lblChuck.TabIndex = 7;
            // 
            // picChuck
            // 
            picChuck.BackColor = Color.DarkOrange;
            picChuck.Location = new Point(660, 256);
            picChuck.Name = "picChuck";
            picChuck.Size = new Size(61, 66);
            picChuck.TabIndex = 8;
            picChuck.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.Location = new Point(379, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 24);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar Resultados";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(445, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 502);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 431);
            label1.Name = "label1";
            label1.Size = new Size(585, 15);
            label1.TabIndex = 12;
            label1.Text = "Los resultatos se guardaran en dos archivo TXT  automaticamente uno se llama Pokemon.txt y otro Chistes.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(892, 489);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLimpiar);
            Controls.Add(picChuck);
            Controls.Add(lblChuck);
            Controls.Add(btnChuckNorris);
            Controls.Add(lblStats);
            Controls.Add(lblNombre);
            Controls.Add(picPokemon);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChuck).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private PictureBox picPokemon;
        private Label lblNombre;
        private Label lblStats;
        private Button btnChuckNorris;
        private Label lblChuck;
        private PictureBox picChuck;
        private Button btnLimpiar;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}

namespace TEST
{
    partial class stats
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baseProjetDataSet = new TEST.BaseProjetDataSet();
            this.pannMachineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pann_MachineTableAdapter = new TEST.BaseProjetDataSetTableAdapters.Pann_MachineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baseProjetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannMachineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseProjetDataSet
            // 
            this.baseProjetDataSet.DataSetName = "BaseProjetDataSet";
            this.baseProjetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pannMachineBindingSource
            // 
            this.pannMachineBindingSource.DataMember = "Pann_Machine";
            this.pannMachineBindingSource.DataSource = this.baseProjetDataSet;
            // 
            // pann_MachineTableAdapter
            // 
            this.pann_MachineTableAdapter.ClearBeforeFill = true;
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "stats";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.baseProjetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannMachineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pannMachineBindingSource;
        private BaseProjetDataSet baseProjetDataSet;
        private BaseProjetDataSetTableAdapters.Pann_MachineTableAdapter pann_MachineTableAdapter;
    }
}

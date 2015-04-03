﻿namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public class Excel : OfficeDocuments, IDocument, IOffice, IEncryptable
    {
        public Excel(string name, string content = null, int size = 0, string version = null, int nRows = 0, int nCols = 0)
            : base(name, content, size, version)
        {
            this.NRols = nRows;
            this.NCols = nCols;
        }

        public int NRols { get; private set; }

        public int NCols { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "rows")
            {
                this.NRols = int.Parse(value);
            }
            else if (key.ToLower() == "cols")
            {
                this.NCols = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}

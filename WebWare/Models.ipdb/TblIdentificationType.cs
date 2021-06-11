using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblIdentificationType
    {
        public TblIdentificationType()
        {
            TblIndependentGameCreatorFile = new HashSet<TblIndependentGameCreatorFile>();
            TblOrganizationBonyadFile = new HashSet<TblOrganizationBonyadFile>();
            TblUserDocumentFile = new HashSet<TblUserDocumentFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblIndependentGameCreatorFile> TblIndependentGameCreatorFile { get; set; }
        public ICollection<TblOrganizationBonyadFile> TblOrganizationBonyadFile { get; set; }
        public ICollection<TblUserDocumentFile> TblUserDocumentFile { get; set; }
    }
}

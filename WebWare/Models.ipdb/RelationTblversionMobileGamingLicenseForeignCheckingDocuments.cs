using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblversionMobileGamingLicenseForeignCheckingDocuments
    {
        public int Id { get; set; }
        public int? MobileGamingLicenseForeignCheckingDocumentsId { get; set; }
        public int? TblversionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}

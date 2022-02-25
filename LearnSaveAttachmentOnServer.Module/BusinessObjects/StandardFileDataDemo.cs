using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSaveAttachmentOnServer.Module.BusinessObjects
{
    [DefaultClassOptions]
    [FileAttachment("File")]
    public class StandardFileDataDemo : BaseObject
    {
        public StandardFileDataDemo(Session session) : base(session) { }
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        public FileData File
        {
            get { return GetPropertyValue<FileData>(nameof(File)); }
            set { SetPropertyValue<FileData>(nameof(File), value); }
        }
    }
}

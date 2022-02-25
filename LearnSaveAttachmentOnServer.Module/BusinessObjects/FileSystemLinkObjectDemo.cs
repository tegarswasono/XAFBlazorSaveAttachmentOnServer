using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using LearnSaveAttachmentOnServer.Module.FileSystemData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSaveAttachmentOnServer.Module.BusinessObjects
{
    [DefaultClassOptions]
    [FileAttachment("File")]
    public class FileSystemLinkObjectDemo : BaseObject
    {
        public FileSystemLinkObjectDemo(Session session) : base(session) { }
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never), ImmediatePostData]
        public FileSystemLinkObject File
        {
            get { return GetPropertyValue<FileSystemLinkObject>("File"); }
            set { SetPropertyValue<FileSystemLinkObject>("File", value); }
        }
    }
}

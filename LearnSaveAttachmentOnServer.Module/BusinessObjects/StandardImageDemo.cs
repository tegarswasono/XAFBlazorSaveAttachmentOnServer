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
    public class StandardImageDemo : BaseObject
    {
        public StandardImageDemo(Session session) : base(session) { }
        
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 40)]
        public MediaDataObject Image
        {
            get { return GetPropertyValue<MediaDataObject>(nameof(Image)); }
            set { SetPropertyValue<MediaDataObject>(nameof(Image), value); }
        }
    }
}

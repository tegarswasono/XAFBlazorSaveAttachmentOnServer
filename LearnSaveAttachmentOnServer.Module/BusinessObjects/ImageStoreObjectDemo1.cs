using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
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
    [RuleCriteria("RuleCriteria for ImageStoreObjectDemo1", DefaultContexts.Save, "ImageEkstentionValidation", CustomMessageTemplate = "Attachment Only Allowed (*.jpg, *.jpeg, *.png) file")]
    public class ImageStoreObjectDemo1 : BaseObject
    {
        public ImageStoreObjectDemo1(Session session) : base(session) { }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public bool IsNewObject
        {
            get { return Session.IsNewObject(this); }
        }
        private bool ImageEkstentionValidation
        {
            get 
            {
                var fileName = File.FileName;
                if (!fileName.Contains(".jpg") && !fileName.Contains(".jpeg") && !fileName.Contains(".png"))
                {
                    return false;
                }
                return true;
            }
        }

        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never), ImmediatePostData]
        public FileSystemStoreObject File
        {
            get { return GetPropertyValue<FileSystemStoreObject>("File"); }
            set { SetPropertyValue<FileSystemStoreObject>("File", value); }
        }

        [NonPersistent]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 40)]
        public byte[] ImagePreview
        {
            get 
            {
                if (File != null)
                {
                    if (File.RealFileName != null)
                    {
                        if (System.IO.File.Exists(File.RealFileName))
                        {
                            return System.IO.File.ReadAllBytes(File.RealFileName);
                        }
                    }
                }
                return new byte[1];
            }
        }
    }
}

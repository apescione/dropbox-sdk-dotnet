// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Information returned by <see
    /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListRevisionsAsync" />.</para>
    /// </summary>
    public sealed class ListRevisionsResult : enc.IEncodable<ListRevisionsResult>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsResult" />
        /// class.</para>
        /// </summary>
        /// <param name="isDeleted">If the file is deleted.</param>
        /// <param name="entries">The revisions for the file. Only non-delete revisions will
        /// show up here.</param>
        public ListRevisionsResult(bool isDeleted,
                                   col.IEnumerable<FileMetadata> entries)
        {
            var entriesList = new col.List<FileMetadata>(entries ?? new FileMetadata[0]);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.IsDeleted = isDeleted;
            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListRevisionsResult()
        {
        }

        /// <summary>
        /// <para>If the file is deleted.</para>
        /// </summary>
        public bool IsDeleted { get; private set; }

        /// <summary>
        /// <para>The revisions for the file. Only non-delete revisions will show up
        /// here.</para>
        /// </summary>
        public col.IList<FileMetadata> Entries { get; private set; }

        #region IEncodable<ListRevisionsResult> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListRevisionsResult>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<bool>("is_deleted", this.IsDeleted);
                obj.AddFieldObjectList<FileMetadata>("entries", this.Entries);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListRevisionsResult enc.IEncodable<ListRevisionsResult>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.IsDeleted = obj.GetField<bool>("is_deleted");
                this.Entries = new col.List<FileMetadata>(obj.GetFieldObjectList<FileMetadata>("entries"));
            }

            return this;
        }

        #endregion
    }
}

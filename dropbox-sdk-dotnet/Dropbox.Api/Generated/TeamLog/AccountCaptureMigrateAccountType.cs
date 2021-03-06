// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The account capture migrate account type object</para>
    /// </summary>
    public class AccountCaptureMigrateAccountType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountCaptureMigrateAccountType> Encoder = new AccountCaptureMigrateAccountTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountCaptureMigrateAccountType> Decoder = new AccountCaptureMigrateAccountTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureMigrateAccountType" /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public AccountCaptureMigrateAccountType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureMigrateAccountType" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AccountCaptureMigrateAccountType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the account capture migrate account type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AccountCaptureMigrateAccountType" />.</para>
        /// </summary>
        private class AccountCaptureMigrateAccountTypeEncoder : enc.StructEncoder<AccountCaptureMigrateAccountType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountCaptureMigrateAccountType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AccountCaptureMigrateAccountType" />.</para>
        /// </summary>
        private class AccountCaptureMigrateAccountTypeDecoder : enc.StructDecoder<AccountCaptureMigrateAccountType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="AccountCaptureMigrateAccountType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountCaptureMigrateAccountType Create()
            {
                return new AccountCaptureMigrateAccountType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AccountCaptureMigrateAccountType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}

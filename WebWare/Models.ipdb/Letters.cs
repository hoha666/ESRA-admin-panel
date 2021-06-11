using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Letters
    {
        public Letters()
        {
            CartableLetters = new HashSet<CartableLetters>();
        }

        public int Id { get; set; }
        public string RegistrationDate { get; set; }
        public string Title { get; set; }
        public string SenderId { get; set; }
        public string PostId { get; set; }
        public string CreatorId { get; set; }
        public string PrivacyLevel { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string LetterType { get; set; }
        public string Keyword { get; set; }
        public string LetterDate { get; set; }
        public string LetterNumber { get; set; }
        public string IndicatorCode { get; set; }
        public string LetterScan { get; set; }
        public string ReceptionType { get; set; }
        public string TemplateId { get; set; }
        public string Context { get; set; }
        public string SendType { get; set; }
        public string Appendix { get; set; }
        public string AccessType { get; set; }
        public string TranscriptReceiver { get; set; }
        public string TranscriptHiddenReceiver { get; set; }
        public string Receiver { get; set; }
        public string RelatedLetter { get; set; }
        public string IsConfirm { get; set; }
        public string ConfirmUser { get; set; }

        public ICollection<CartableLetters> CartableLetters { get; set; }
    }
}

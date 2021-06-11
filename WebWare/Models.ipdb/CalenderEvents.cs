using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalenderEvents
    {
        public CalenderEvents()
        {
            CalendarEventGroupShares = new HashSet<CalendarEventGroupShares>();
            CalendarEventParticipantGroups = new HashSet<CalendarEventParticipantGroups>();
            CalendarEventParticipants = new HashSet<CalendarEventParticipants>();
            CalendarEventPersonShares = new HashSet<CalendarEventPersonShares>();
            CartableLettersCalenderEvent = new HashSet<CartableLetters>();
            CartableLettersProceedings = new HashSet<CartableLetters>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public int? Type { get; set; }
        public string Owner { get; set; }
        public string Participants { get; set; }
        public string ParticipantsGroup { get; set; }
        public string ShareType { get; set; }
        public string Description { get; set; }
        public string PersonShare { get; set; }
        public string GroupShare { get; set; }
        public string MeetingType { get; set; }
        public string Project { get; set; }
        public string Appendix { get; set; }
        public string ReminderDescription { get; set; }
        public string ReminderType { get; set; }
        public string NameFamilyForeign { get; set; }
        public string OrganizationForeign { get; set; }
        public string PostForeign { get; set; }
        public string EmailForeign { get; set; }
        public string PhoneNumberForeign { get; set; }
        public string MeetingSecretary { get; set; }
        public bool? IsCheckedByScheduler { get; set; }
        public string MeetingSummary { get; set; }
        public string MeetingDecision { get; set; }
        public string MeetingSuggestion { get; set; }
        public string AlertHourBefore { get; set; }
        public string AlertTypes { get; set; }
        public DateTime AlertDateTime { get; set; }
        public bool? IsCheckedBySchedulerForReminder { get; set; }
        public bool IsDeActive { get; set; }

        public ICollection<CalendarEventGroupShares> CalendarEventGroupShares { get; set; }
        public ICollection<CalendarEventParticipantGroups> CalendarEventParticipantGroups { get; set; }
        public ICollection<CalendarEventParticipants> CalendarEventParticipants { get; set; }
        public ICollection<CalendarEventPersonShares> CalendarEventPersonShares { get; set; }
        public ICollection<CartableLetters> CartableLettersCalenderEvent { get; set; }
        public ICollection<CartableLetters> CartableLettersProceedings { get; set; }
    }
}

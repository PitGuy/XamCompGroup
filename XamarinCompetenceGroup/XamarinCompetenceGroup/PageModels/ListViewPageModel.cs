using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCompetenceGroup.Models;

namespace XamarinCompetenceGroup.PageModels
{
    public class ListViewPageModel : FreshMvvm.FreshBasePageModel
    {
        public ObservableCollection<Meeting> Meetings { get; set; }

        public ListViewPageModel()
        {
            Meetings = new ObservableCollection<Meeting>();
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            Meetings.Add(new Meeting { 
                Id = 1,
                Author = "Jan Kowalsky",
                Title = "Strange injection"
            });
            Meetings.Add(new Meeting
            {
                Id = 1,
                Author = "Jan Nowak",
                Title = "Xamarin vs React Native"
            });
            Meetings.Add(new Meeting
            {
                Id = 1,
                Author = "Artur Król",
                Title = "Temperatura kamiena jest ważna"
            });
            Meetings.Add(new Meeting
            {
                Id = 1,
                Author = "Jacek Ibrahimowicz",
                Title = "Pilka - to kula"
            });
        }

        public override void ReverseInit(object returnedData)
        {
            if (returnedData is Meeting meeting)
            {
                if(meeting.Id == -1)
                {
                    meeting.Id = Meetings.Select(m => m.Id).OrderBy(x=>x).FirstOrDefault() + 1;
                    Meetings.Add(meeting);
                }
            }
            base.ReverseInit(returnedData);
        }

        private ICommand meetingTapCommand;
        public ICommand MeetingTapCommand => meetingTapCommand ?? (meetingTapCommand = new Command<Meeting>(async (meeting) => await NavigateToMeetingPage(meeting)));

        private async Task NavigateToMeetingPage(Meeting meeting)
        {
            await CoreMethods.PushPageModel<MeetingPageModel>(meeting);
        }

        private ICommand newMeetingCommand;
        public ICommand NewMeetingCommand => newMeetingCommand ?? (newMeetingCommand = new Command(async () => await NavigateToMeetingPage(null)));

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCompetenceGroup.Models;

namespace XamarinCompetenceGroup.PageModels
{
    public class MeetingPageModel : FreshMvvm.FreshBasePageModel
    {
        public Meeting Meeting { get; set; }

        public override void Init(object initData)
        {
            if(initData is Meeting meeting)
            {
                this.Meeting = meeting;
            }
            else
            {
                this.Meeting = new Meeting { Id = -1 };
            }
            base.Init(initData);
        }

        private ICommand saveCommand;
        public ICommand SaveCommand => saveCommand ?? (saveCommand = new Command(async () => await SaveAndCloseMeeting()));

        private async Task SaveAndCloseMeeting()
        {
            await CoreMethods.PopPageModel(Meeting);
        }
    }
}

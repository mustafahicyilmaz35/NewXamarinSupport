using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OutlookProject.Interfaces
{
    public interface INotePadService
    {
        Task<bool> NotepadLaunch(string notes);
    }
}

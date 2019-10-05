using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sekreter.Core.Interfaces
{
    public interface INoteService
    {
        Task<bool> NotepadLaunch(string notes);
    }
}

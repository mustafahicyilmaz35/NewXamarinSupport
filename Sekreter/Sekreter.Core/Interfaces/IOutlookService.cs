using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sekreter.Core.Interfaces
{
    public interface IOutlookService
    {
        Task<bool> Launch(string to, string cc, string subject, string text);
    }
}

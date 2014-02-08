using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POC_Translation.Models;

namespace POC_Translation.Services
{
    interface ILanguageService
    {
        IList<LanguageModel> GetAllText(object[] english);
    }
}

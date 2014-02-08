using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using POC_Translation.Models;

namespace POC_Translation.Services
{
    public class LanguageService: ILanguageService
    {
        public IList<LanguageModel> GetAllText(object[] english)
        {
            var database = DatabaseFactory.CreateDatabase();
            return database.ExecuteSprocAccessor<LanguageModel>("EditorialArticle.ArticleSelect", english).ToList();
        }

    }
}
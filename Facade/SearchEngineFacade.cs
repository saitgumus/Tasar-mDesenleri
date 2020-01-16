using System;
using Facade.SearchEngine;

namespace Facade
{
    public class SearchEngineFacade
    {
        private readonly DataIndexers dataIndexers;
        private readonly RetrievingData retrievingData;
        private readonly GeneratingSnippets generatingSnippets;
        private readonly PresentingResoult presentingResoult;

        public SearchEngineFacade()
        {
            dataIndexers = new DataIndexers();
            retrievingData = new RetrievingData();
            generatingSnippets = new GeneratingSnippets();
            presentingResoult = new PresentingResoult();
        }


        public string GetSearchingResults(string query)
        {
            var indeexes = dataIndexers.GetIndexesOfStoreData(query);
            retrievingData.GetData(indeexes);
            generatingSnippets.GenereateSnippets();
            presentingResoult.PresentResult();
            return $"{query} sorgusu için arama sonucları: ... ";
        }
    }
}

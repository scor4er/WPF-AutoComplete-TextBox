using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WpfConstrols.Demo.Model;
using WpfControls.Editors;

namespace WpfConstrols.Demo.Providers
{
    public class CommaSeparatedStatesSuggestionProvider : ISuggestionProvider
    {
        private const char Separator = ',';
        public IEnumerable<State> ListOfStates { get; set; }

        public IEnumerable GetSuggestions(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return null;
            return
                ListOfStates
                    .Where(state => state.Name.StartsWith(filter.Split(Separator).LastOrDefault() ?? "", StringComparison.CurrentCultureIgnoreCase))
                    .ToList();

        }

        public CommaSeparatedStatesSuggestionProvider()
        {
            var states = StateFactory.CreateStateList();
            ListOfStates = states;
        }
    }
}
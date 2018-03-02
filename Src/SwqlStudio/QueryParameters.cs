﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SolarWinds.InformationService.Contract2;
using WeifenLuo.WinFormsUI.Docking;

namespace SwqlStudio
{
    public partial class QueryParameters : DockContent
    {
        private readonly Dictionary<string, string> lastKnownValues = new Dictionary<string, string>();

        public bool AllowSetParameters { get; set; }

        public QueryParameters()
        {
            InitializeComponent();
            parametersGrid.DataSource = new BindingList<QueryVariable>();
            AllowSetParameters = true;
        }

        public PropertyBag Parameters
        {
            get
            {
                var bag = new PropertyBag();
                foreach (QueryVariable pair in (BindingList<QueryVariable>)parametersGrid.DataSource)
                    bag[pair.Key] = pair.Value;

                return bag;
            }

            set
            {
                if (!this.AllowSetParameters)
                    return;

                UpdateFromLastKnown(value);
                var currentVariables = (BindingList<QueryVariable>)parametersGrid.DataSource;
                UpdateWithCurrentValues(value, currentVariables);
                var pairs = value.Select(pair => new QueryVariable(pair.Key, pair.Value?.ToString()));
                var ordered = pairs.OrderBy(p => p.Key).ToList();
                parametersGrid.DataSource = new BindingList<QueryVariable>(ordered) { AllowNew = true };
            }
        }

        private void UpdateWithCurrentValues(PropertyBag propertyBag, BindingList<QueryVariable> currentVariables)
        {
            foreach (QueryVariable variable in currentVariables.Where(v => v.Key != null))
            {
                if (propertyBag.ContainsKey(variable.Key))
                {
                    propertyBag[variable.Key] = variable.Value;
                }
                else if (!string.IsNullOrEmpty(variable.Value))
                {
                    lastKnownValues[variable.Key] = variable.Value;
                }
            }
        }

        private void UpdateFromLastKnown(PropertyBag propertyBag)
        {
            foreach (string preservedKey in lastKnownValues.Keys.Where(propertyBag.ContainsKey))
            {
                propertyBag[preservedKey] = lastKnownValues[preservedKey];
            }
        }
    }
}

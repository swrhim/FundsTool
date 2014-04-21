using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsTool.Model
{
    public class ModelBase : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        private Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        protected void NotifyPropertyChanged(string propertyName, Action<bool> message)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                if (message != null)
                    message(this.IsValid);
            }
        }

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (this._errors.ContainsKey(propertyName))
                return this._errors[propertyName];
            return null;
        }

        public bool HasErrors
        {
            get { return this._errors.Count > 0; }
        }

        public bool IsValid
        {
            get { return !this.HasErrors; }
        }

        public void AddError(string propertyName, string error)
        {
            this._errors[propertyName] = new List<string>() { error };
            this.NotifyErrorsChanged(propertyName);
        }

        public void RemoveError(string propertyName)
        {
            // remove error
            if (this._errors.ContainsKey(propertyName))
                this._errors.Remove(propertyName);
            this.NotifyErrorsChanged(propertyName);
        }

        public void NotifyErrorsChanged(string propertyName)
        {
            // Notify
            if (this.ErrorsChanged != null)
                this.ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}

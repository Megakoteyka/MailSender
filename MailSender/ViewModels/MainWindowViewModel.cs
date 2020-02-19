using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;
using MailSender.Lib.Services;
using MailSender.Lib.Services.Base;
using MailSender.Lib.Services.DebugServices;
using MailSender.Views;
using Xceed.Wpf.Toolkit.Core.Converters;

namespace MailSender.ViewModels
{
    [SuppressMessage("ReSharper", "PrivateFieldCanBeConvertedToLocalVariable")]
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IDbContextService<MailSenderDbContext> _dbContextService;

        private readonly IServersManager _serversManager;
        private readonly ISendersManager _sendersManager;
        private readonly IRecipientsManager _recipientsManager;
        private readonly IMailsManager _mailsManager;

        private ObservableCollection<Server> _servers;
        private ObservableCollection<Sender> _senders;
        private ObservableCollection<Recipient> _recipients;
        private ObservableCollection<Mail> _letters;

        private Server _selectedServer;
        private Sender _selectedSender;
        private Recipient _selectedRecipient;
        private Mail _selectedMail;

        public ObservableCollection<Server> Servers
        {
            get => _servers;
            private set => Set(ref _servers, value);
        }

        public ObservableCollection<Sender> Senders
        {
            get => _senders;
            private set => Set(ref _senders, value);
        }

        public ObservableCollection<Recipient> Recipients
        {
            get => _recipients;
            private set => Set(ref _recipients, value);
        }

        public ObservableCollection<Mail> Letters
        {
            get => _letters;
            private set => Set(ref _letters, value);
        }


        public Server SelectedServer
        {
            get => _selectedServer;
            set => Set(ref _selectedServer, value);
        }

        public Sender SelectedSender
        {
            get => _selectedSender;
            set => Set(ref _selectedSender, value);
        }

        public Recipient SelectedRecipient
        {
            get => _selectedRecipient;
            set => Set(ref _selectedRecipient, value);
        }

        public Mail SelectedMail
        {
            get => _selectedMail;
            set => Set(ref _selectedMail, value);
        }








        #region Commands

        public ICommand AddServerCommand { get; }
        public ICommand DeleteServerCommand { get; }
        public ICommand EditServerCommand { get; }

        public ICommand AddSenderCommand { get; }
        public ICommand DeleteSenderCommand { get; }
        public ICommand EditSenderCommand { get; }


        public ICommand RefreshRecipientsCommand { get; }

        public ICommand SendMailCommand { get; }

        public ICommand SaveRecipientCommand { get; }
        public ICommand CreateRecipientCommand { get; }

        #endregion


        public MainWindowViewModel(
            IServersManager serversManager,
            ISendersManager sendersManager,
            IRecipientsManager recipientsManager,
            IMailsManager mailsManager,
            IDbContextService<MailSenderDbContext> dbContextService)
        {
            _serversManager = serversManager;
            _sendersManager = sendersManager;
            _recipientsManager = recipientsManager;
            _mailsManager = mailsManager;

            _dbContextService = dbContextService;

            Servers = new ObservableCollection<Server>(_serversManager.Read());
            Senders = new ObservableCollection<Sender>(_sendersManager.Read());
            Recipients = new ObservableCollection<Recipient>(_recipientsManager.Read());
            Letters = new ObservableCollection<Mail>(_mailsManager.Read());

            SelectedServer = _servers.FirstOrDefault();
            SelectedSender = _senders.FirstOrDefault();
            SelectedRecipient = _recipients.FirstOrDefault();
            SelectedMail = _letters.FirstOrDefault();


            #region Commands

            AddServerCommand = new RelayCommand(
                () =>
                {
                    var dialog = new EditServerWindow
                    {
                        Owner = Application.Current.MainWindow,
                        DataContext = new Server()
                    };

                    if (dialog.ShowDialog() != true)
                        return;

                    var server = dialog.DataContext as Server;

                    _serversManager.Add(server);
                    Servers = new ObservableCollection<Server>(_serversManager.Read());
                    SelectedServer = server;
                },
                () => true);

            DeleteServerCommand = new RelayCommand(
                () =>
                {
                    // TODO запросить подтверждение удаления
                    _serversManager.Delete(SelectedServer);
                    Servers = new ObservableCollection<Server>(_serversManager.Read());
                },
                () => SelectedServer != null);

            EditServerCommand = new RelayCommand(
                () =>
                {
                    var dialog = new EditServerWindow
                    {
                        Owner = Application.Current.MainWindow,
                        DataContext = SelectedServer.Clone() as Server
                    };

                    if (dialog.ShowDialog() != true)
                        return;

                    var server = dialog.DataContext as Server;

                    _serversManager.Update(server);
                    Servers = new ObservableCollection<Server>(_serversManager.Read());
                    SelectedServer = server;
                },
                () => SelectedServer != null);


            AddSenderCommand = new RelayCommand(
                () => throw new NotImplementedException(),
                () => true);

            DeleteSenderCommand=new RelayCommand(
                () => throw new NotImplementedException(),
                () => true);

            EditSenderCommand= new RelayCommand(
                () => throw new NotImplementedException(),
                () => true);


            RefreshRecipientsCommand = new RelayCommand(
                () => Recipients = new ObservableCollection<Recipient>(_recipientsManager.Read()),
                () => true);

            SendMailCommand = new RelayCommand(
                () => new DebugMailSender(SelectedServer).Send(SelectedMail, SelectedSender.Address, SelectedRecipient.Address), 
                () => SelectedServer != null && SelectedMail != null && SelectedSender != null && SelectedRecipient != null);

            SaveRecipientCommand = new RelayCommand(
                () => _recipientsManager.Update(SelectedRecipient),
                () => SelectedRecipient != null);

            CreateRecipientCommand = new RelayCommand(
                () =>
                {
                    var newRecipient = new Recipient {Name = "New recipient", Address = "new@recipient.com"};
                    _recipientsManager.Add(newRecipient);
                    SelectedRecipient = newRecipient;
                },
                () => true);

            #endregion
        }
        }
}

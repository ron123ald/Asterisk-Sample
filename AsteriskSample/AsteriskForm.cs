using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Asterisk.NET.Manager;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Asterisk.NET.Manager.Action;
using System.Configuration;
using Asterisk.NET.Manager.Response;

namespace AsteriskSample
{
    public partial class AsteriskForm : Form
    {
        public delegate void onOriginate(string channel, string exten, string callerid);
        public delegate void onHangup(string channel);
        
        public event onOriginate onStartCall;
        public event onHangup onEndCall;

        ManagerConnection manager = null;
        AsteriskData data = null;

        public AsteriskForm()
        {
            InitializeComponent();
        }

        private void AsteriskForm_Load(object sender, EventArgs e)
        {
            controlGroup.Enabled = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                manager = new ManagerConnection(this.AsteriskHost.Text,
                                                    int.Parse(this.AsteriskPort.Text),
                                                    this.AsteriskUsername.Text,
                                                    this.AsteriskPassword.Text);
                manager.Login();
                if (manager.IsConnected())
                {
                    controlGroup.Enabled = true;
                    credentialGroup.Enabled = false;
                    MessageBox.Show(this, String.Format("{0} was Successfuly Initiated", AsteriskHost.Text), "Asterisk Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AsteriskLogs.Text = "***WELCOME***";

                    // Set up AMI Eventhandlers
                    manager.OriginateResponse += new OriginateResponseEventHandler(manager_OriginateResponse);
                    manager.NewChannel += new NewChannelEventHandler(manager_NewChannel);
                    manager.Hangup += new HangupEventHandler(manager_Hangup);
                    manager.ExtensionStatus += new ExtensionStatusEventHandler(manager_ExtensionStatus);

                    // Set up AMI properties
                    manager.DefaultEventTimeout = 300000;
                    manager.DefaultResponseTimeout = 300000;
                    manager.KeepAlive = true;
                    manager.KeepAliveAfterAuthenticationFailure = true;
                    manager.FireAllEvents = true;

                    data = new AsteriskData();

                    // set up user eventhandlers
                    onStartCall += new onOriginate(AsteriskForm_onOriginateAction);
                    onEndCall += new onHangup(AsteriskForm_onEndCall);
                }
                else
                    throw new Exception("Error on Asterisk login");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, String.Format("{0} was unSuccessfuly Initiated{1}Error Message: {2}", AsteriskHost.Text, Environment.NewLine, ex.Message), "Asterisk Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void manager_ExtensionStatus(object sender, Asterisk.NET.Manager.Event.ExtensionStatusEvent e)
        {
            if (e != null && !String.IsNullOrEmpty(e.Exten))
            {
                if (e.Status == 1)
                {
                    if (e.Exten.Contains(Caller1.Text))
                        PopulateLogs(String.Format("Caller 1 answer the call. phone number: {0}", Caller1.Text));
                    else if (e.Exten.Contains(Caller2.Text))
                        PopulateLogs(String.Format("Caller 2 answer the call. phone number: {0}", Caller2.Text));
                }
            }
        }

        void AsteriskForm_onEndCall(string channel)
        {
            HangupAction haction = new HangupAction()
            {
                Channel = channel
            };
            sendaction(haction);
        }

        void AsteriskForm_onOriginateAction(string channel, string exten, string callerid)
        {
            data = new AsteriskData();
            data.originate_channel = channel;
            data.originate_exten = exten;
            data.originate_callerid = callerid;

            OriginateAction oaction = originate(data);
            ManagerResponse oresponse = sendaction(oaction);
        }

        void manager_Hangup(object sender, Asterisk.NET.Manager.Event.HangupEvent e)
        {
            switch (e.Cause)
            {
                case 16: case 17:
                    // normal clearing
                    data = null;
                    PopulateLogs("call is ended.");
                    break;
                case 19:
                    // no answer
                    PopulateLogs("No answer.. hanging up.");
                    break;
                default:
                    break;
            }
        }

        void manager_NewChannel(object sender, Asterisk.NET.Manager.Event.NewChannelEvent e)
        {
            // checking if channel containing caller 1's number
            if (e.Channel.Contains(this.Caller1.Text))
            {
                // then caller1_channel is e.channel and unique_id
                data.channel_caller1 = e.Channel;
                data.uniqueid_caller1 = e.UniqueId; 
                PopulateLogs(string.Format("Originating call to caller 1. extension: {0}", Caller1.Text));
            }
            else if (e.Channel.Contains(this.Caller2.Text))
            {
                // then caller2_channel is e.channel and unique_id
                data.channel_caller2 = e.Channel;
                data.uniqueid_caller2 = e.UniqueId;
                PopulateLogs(string.Format("Originating call to caller 2. extension: {0}", Caller2.Text));
            }
        }

        void manager_OriginateResponse(object sender, Asterisk.NET.Manager.Event.OriginateResponseEvent e)
        {
            switch (e.Reason)
            {
                case 3:
                    // Ringing but user didn't Answer
                    PopulateLogs(String.Format("Caller 1 did not answer the call."));
                    break;
                case 4: 
                    // Asnwered
                    PopulateLogs("Phone answered");
                    break;
                case 5:
                    // Remote end is busy
                    PopulateLogs("Remote End is Busy. ");
                    break;
                case 8:
                    // Circuits busy
                    PopulateLogs("All circuits are Busy now please try your call again later.");
                    break;
                default: break;
            }
        }


        private void StartCallButton_Click(object sender, EventArgs e)
        {
            // Fire onStartCall Event
            onStartCall(this.Caller1.Text, this.Caller2.Text, this.CallerID.Text);
            
            this.StartCallButton.Enabled = false;
            this.EndCallButton.Enabled = true;
        }

        private void EndCallButton_Click(object sender, EventArgs e)
        {
            // Fire onEndCall Event
            onEndCall(data.channel_caller1);
            onEndCall(data.channel_caller2);

            this.StartCallButton.Enabled = true;
            this.EndCallButton.Enabled = false;
        }

        public void PopulateLogs(string Message)
        {
            this.AsteriskLogs.Invoke((MethodInvoker)(() =>
            {
                // Here we append DateTime.Now to the Message to see what time did the event pass through
                AsteriskLogs.AppendText(Environment.NewLine + "[ " + DateTime.Now + " ] " + Message + Environment.NewLine);
            }));
        }

        public OriginateAction originate(AsteriskData data)
        {
            OriginateAction oaction = new OriginateAction()
            {
                ActionId = data.originate_actionid,
                // Exten: is the number you're calling
                Exten = data.originate_exten,
                // Channel 
                Channel = data.originate_channel,
                // Context 
                Context = ConfigurationManager.AppSettings.Get("default_context"),
                CallerId = data.originate_callerid,
                Async = true,
                Priority = 1,
                // phone ring Timeout (default timeout is 30000 = 30 secs);
                Timeout = int.Parse(ConfigurationManager.AppSettings.Get("default_timeout"))
            };
            return oaction;
        }

        public ManagerResponse sendaction(ManagerAction action)
        {
            ManagerResponse response = null;
            try
            {
                if (action != null)
                {
                    // sending action to manager
                    manager.SendAction(action);
                }
                else
                    throw new Exception("action is null");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }

    public class AsteriskData : OriginateData
    {
        private string _caller1_channel;
        private string _caller1_uniqueid;
        private string _caller2_channel;
        private string _caller2_uniqueid;

        public string channel_caller1
        {
            get { return _caller1_channel; }
            set { _caller1_channel = !String.IsNullOrEmpty(value) ? value : ""; }
        }
        public string uniqueid_caller1
        {
            get { return _caller1_uniqueid; }
            set { _caller1_uniqueid = !String.IsNullOrEmpty(value) ? value : ""; }
        }
        public string channel_caller2
        {
            get { return _caller2_channel; }
            set { _caller2_channel = !String.IsNullOrEmpty(value) ? value : ""; }
        }
        public string uniqueid_caller2
        {
            get { return _caller2_uniqueid; }
            set { _caller2_uniqueid = !String.IsNullOrEmpty(value) ? value : ""; }
        }
        public override string ToString()
        {
            return "{\"caller1_channel\":\"" + channel_caller1 + "\"," +
                    "\"caller1_uniqueid\":\"" + uniqueid_caller1 + "\"," +
                    "\"caller2_channel\":\"" + channel_caller2 + "\"," +
                    "\"caller2_uniqueid\":\"" + uniqueid_caller2 + "\"," +
                    "\"originate_callerid\":\"" + originate_callerid + "\"," +
                    "\"originate_channel\":\"" + originate_channel + "\"," +
                    "\"originate_exten\":\"" + originate_exten + "\"}";
        }

        public void Dispose()
        {
            channel_caller1 = string.Empty;
            uniqueid_caller1 = string.Empty;
            originate_callerid = string.Empty;
            originate_channel = string.Empty;
            originate_exten = string.Empty;
        }
    }

    public class OriginateData
    {
        private string _originate_callerid;
        private string _originate_channel;
        private string _originate_exten;

        public string originate_actionid
        {
            get { return _originate_channel.GetHashCode().ToString(); }
        }
        public string originate_callerid
        {
            get { return _originate_callerid; }
            set { _originate_callerid = !String.IsNullOrEmpty(value) ? value : ""; }
        }
        public string originate_channel
        {
            get { return _originate_channel; }
            set 
            {
                if (value.Length > 5)
                    _originate_channel = "SIP/" + value + "@Vitel-Out";
                else
                    _originate_channel = "SIP/" + value;
            }
        }
        public string originate_exten
        {
            get { return _originate_exten; }
            set { _originate_exten = !String.IsNullOrEmpty(value) ? value : ""; }
        }
    }
}

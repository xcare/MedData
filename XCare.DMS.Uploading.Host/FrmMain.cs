﻿using System.Windows.Forms;
﻿using XCare.DMS.Uploading.Events;
﻿using XCare.DMS.Uploading.Events.Bryz;
﻿using XCare.DMS.Uploading.Events.Bryz;
﻿using XCare.DMS.Uploading.Events.Jbxx;
﻿using XCare.DMS.Utilities.Event;

namespace XCare.DMS.Uploading.Host
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            XCareEvents.Raise(new BryzxxCreatedEvent(null));
            XCareEvents.Raise(new JbxxUpdatedEvent());
        }
    }
}
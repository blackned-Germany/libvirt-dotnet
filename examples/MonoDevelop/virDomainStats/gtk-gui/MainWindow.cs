
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table1;

	private global::Gtk.Button button1;

	private global::Gtk.ComboBox cbDomains;

	private global::Gtk.Entry entry1;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.Table table2;

	private global::Gtk.Entry eCPUTime;

	private global::Gtk.Entry eMaxMem;

	private global::Gtk.Entry eMemory;

	private global::Gtk.Entry eNumVirtCPU;

	private global::Gtk.Entry eState;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Label label5;

	private global::Gtk.Label label6;

	private global::Gtk.Label label7;

	private global::Gtk.Label GtkLabel1;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Table table3;

	private global::Gtk.ComboBox cbBlockDevice;

	private global::Gtk.Entry eErrors;

	private global::Gtk.Entry eReadBytes;

	private global::Gtk.Entry eReadRequests;

	private global::Gtk.Entry eWriteBytes;

	private global::Gtk.Entry eWriteRequests;

	private global::Gtk.Label label10;

	private global::Gtk.Label label11;

	private global::Gtk.Label label12;

	private global::Gtk.Label label13;

	private global::Gtk.Label label8;

	private global::Gtk.Label label9;

	private global::Gtk.Label GtkLabel2;

	private global::Gtk.Frame frame4;

	private global::Gtk.Alignment GtkAlignment2;

	private global::Gtk.Table table5;

	private global::Gtk.ComboBox cbInterface;

	private global::Gtk.Entry eRxBytes;

	private global::Gtk.Entry eRxDrops;

	private global::Gtk.Entry eRxErrs;

	private global::Gtk.Entry eRxPackets;

	private global::Gtk.Entry eTxBytes;

	private global::Gtk.Entry eTxDrops;

	private global::Gtk.Entry eTxErrs;

	private global::Gtk.Entry eTxPackets;

	private global::Gtk.Label label15;

	private global::Gtk.Label label16;

	private global::Gtk.Label label17;

	private global::Gtk.Label label18;

	private global::Gtk.Label label19;

	private global::Gtk.Label label20;

	private global::Gtk.Label label21;

	private global::Gtk.Label label22;

	private global::Gtk.Label label23;

	private global::Gtk.Label GtkLabel3;

	private global::Gtk.Label label1;

	private global::Gtk.Label label14;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("Connect");
		this.table1.Add (this.button1);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.button1]));
		w1.TopAttach = ((uint)(1));
		w1.BottomAttach = ((uint)(2));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.cbDomains = global::Gtk.ComboBox.NewText ();
		this.cbDomains.Name = "cbDomains";
		this.table1.Add (this.cbDomains);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.cbDomains]));
		w2.TopAttach = ((uint)(2));
		w2.BottomAttach = ((uint)(3));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.Text = global::Mono.Unix.Catalog.GetString ("qemu+tcp://192.168.220.198/session");
		this.entry1.IsEditable = true;
		this.table1.Add (this.entry1);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.entry1]));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.eCPUTime = new global::Gtk.Entry ();
		this.eCPUTime.CanFocus = true;
		this.eCPUTime.Name = "eCPUTime";
		this.eCPUTime.IsEditable = false;
		this.table2.Add (this.eCPUTime);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.eCPUTime]));
		w4.TopAttach = ((uint)(4));
		w4.BottomAttach = ((uint)(5));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.eMaxMem = new global::Gtk.Entry ();
		this.eMaxMem.CanFocus = true;
		this.eMaxMem.Name = "eMaxMem";
		this.eMaxMem.IsEditable = false;
		this.table2.Add (this.eMaxMem);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.eMaxMem]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.eMemory = new global::Gtk.Entry ();
		this.eMemory.CanFocus = true;
		this.eMemory.Name = "eMemory";
		this.eMemory.IsEditable = false;
		this.table2.Add (this.eMemory);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.eMemory]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.eNumVirtCPU = new global::Gtk.Entry ();
		this.eNumVirtCPU.CanFocus = true;
		this.eNumVirtCPU.Name = "eNumVirtCPU";
		this.eNumVirtCPU.IsEditable = false;
		this.table2.Add (this.eNumVirtCPU);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.eNumVirtCPU]));
		w7.TopAttach = ((uint)(3));
		w7.BottomAttach = ((uint)(4));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.eState = new global::Gtk.Entry ();
		this.eState.CanFocus = true;
		this.eState.Name = "eState";
		this.eState.IsEditable = false;
		this.table2.Add (this.eState);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.eState]));
		w8.LeftAttach = ((uint)(1));
		w8.RightAttach = ((uint)(2));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("State :");
		this.table2.Add (this.label3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Max. memory :");
		this.table2.Add (this.label4);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Memory :");
		this.table2.Add (this.label5);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
		w11.TopAttach = ((uint)(2));
		w11.BottomAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Num. virt CPU :");
		this.table2.Add (this.label6);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
		w12.TopAttach = ((uint)(3));
		w12.BottomAttach = ((uint)(4));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("CPU time :");
		this.table2.Add (this.label7);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
		w13.TopAttach = ((uint)(4));
		w13.BottomAttach = ((uint)(5));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment.Add (this.table2);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label ();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Domain infos</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.table1.Add (this.frame1);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.frame1]));
		w16.TopAttach = ((uint)(3));
		w16.BottomAttach = ((uint)(4));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.table3 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.cbBlockDevice = global::Gtk.ComboBox.NewText ();
		this.cbBlockDevice.Name = "cbBlockDevice";
		this.table3.Add (this.cbBlockDevice);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3[this.cbBlockDevice]));
		w17.LeftAttach = ((uint)(1));
		w17.RightAttach = ((uint)(2));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.eErrors = new global::Gtk.Entry ();
		this.eErrors.CanFocus = true;
		this.eErrors.Name = "eErrors";
		this.eErrors.IsEditable = false;
		this.table3.Add (this.eErrors);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3[this.eErrors]));
		w18.TopAttach = ((uint)(5));
		w18.BottomAttach = ((uint)(6));
		w18.LeftAttach = ((uint)(1));
		w18.RightAttach = ((uint)(2));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.eReadBytes = new global::Gtk.Entry ();
		this.eReadBytes.CanFocus = true;
		this.eReadBytes.Name = "eReadBytes";
		this.eReadBytes.IsEditable = false;
		this.table3.Add (this.eReadBytes);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3[this.eReadBytes]));
		w19.TopAttach = ((uint)(2));
		w19.BottomAttach = ((uint)(3));
		w19.LeftAttach = ((uint)(1));
		w19.RightAttach = ((uint)(2));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.eReadRequests = new global::Gtk.Entry ();
		this.eReadRequests.CanFocus = true;
		this.eReadRequests.Name = "eReadRequests";
		this.eReadRequests.IsEditable = false;
		this.table3.Add (this.eReadRequests);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table3[this.eReadRequests]));
		w20.TopAttach = ((uint)(1));
		w20.BottomAttach = ((uint)(2));
		w20.LeftAttach = ((uint)(1));
		w20.RightAttach = ((uint)(2));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.eWriteBytes = new global::Gtk.Entry ();
		this.eWriteBytes.CanFocus = true;
		this.eWriteBytes.Name = "eWriteBytes";
		this.eWriteBytes.IsEditable = false;
		this.table3.Add (this.eWriteBytes);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3[this.eWriteBytes]));
		w21.TopAttach = ((uint)(4));
		w21.BottomAttach = ((uint)(5));
		w21.LeftAttach = ((uint)(1));
		w21.RightAttach = ((uint)(2));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.eWriteRequests = new global::Gtk.Entry ();
		this.eWriteRequests.CanFocus = true;
		this.eWriteRequests.Name = "eWriteRequests";
		this.eWriteRequests.IsEditable = false;
		this.table3.Add (this.eWriteRequests);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table3[this.eWriteRequests]));
		w22.TopAttach = ((uint)(3));
		w22.BottomAttach = ((uint)(4));
		w22.LeftAttach = ((uint)(1));
		w22.RightAttach = ((uint)(2));
		w22.XOptions = ((global::Gtk.AttachOptions)(4));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Read bytes :");
		this.table3.Add (this.label10);
		global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table3[this.label10]));
		w23.TopAttach = ((uint)(2));
		w23.BottomAttach = ((uint)(3));
		w23.XOptions = ((global::Gtk.AttachOptions)(4));
		w23.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Write requests :");
		this.table3.Add (this.label11);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table3[this.label11]));
		w24.TopAttach = ((uint)(3));
		w24.BottomAttach = ((uint)(4));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Write bytes :");
		this.table3.Add (this.label12);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table3[this.label12]));
		w25.TopAttach = ((uint)(4));
		w25.BottomAttach = ((uint)(5));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Errors :");
		this.table3.Add (this.label13);
		global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table3[this.label13]));
		w26.TopAttach = ((uint)(5));
		w26.BottomAttach = ((uint)(6));
		w26.XOptions = ((global::Gtk.AttachOptions)(4));
		w26.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Block device :");
		this.table3.Add (this.label8);
		global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table3[this.label8]));
		w27.XOptions = ((global::Gtk.AttachOptions)(4));
		w27.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Read requests :");
		this.table3.Add (this.label9);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table3[this.label9]));
		w28.TopAttach = ((uint)(1));
		w28.BottomAttach = ((uint)(2));
		w28.XOptions = ((global::Gtk.AttachOptions)(4));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment1.Add (this.table3);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Block statistics</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel2;
		this.table1.Add (this.frame2);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1[this.frame2]));
		w31.TopAttach = ((uint)(3));
		w31.BottomAttach = ((uint)(4));
		w31.LeftAttach = ((uint)(1));
		w31.RightAttach = ((uint)(2));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.table5 = new global::Gtk.Table (((uint)(9)), ((uint)(2)), false);
		this.table5.Name = "table5";
		this.table5.RowSpacing = ((uint)(6));
		this.table5.ColumnSpacing = ((uint)(6));
		// Container child table5.Gtk.Table+TableChild
		this.cbInterface = global::Gtk.ComboBox.NewText ();
		this.cbInterface.Name = "cbInterface";
		this.table5.Add (this.cbInterface);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table5[this.cbInterface]));
		w32.LeftAttach = ((uint)(1));
		w32.RightAttach = ((uint)(2));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eRxBytes = new global::Gtk.Entry ();
		this.eRxBytes.CanFocus = true;
		this.eRxBytes.Name = "eRxBytes";
		this.eRxBytes.IsEditable = false;
		this.table5.Add (this.eRxBytes);
		global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table5[this.eRxBytes]));
		w33.TopAttach = ((uint)(1));
		w33.BottomAttach = ((uint)(2));
		w33.LeftAttach = ((uint)(1));
		w33.RightAttach = ((uint)(2));
		w33.XOptions = ((global::Gtk.AttachOptions)(4));
		w33.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eRxDrops = new global::Gtk.Entry ();
		this.eRxDrops.CanFocus = true;
		this.eRxDrops.Name = "eRxDrops";
		this.eRxDrops.IsEditable = false;
		this.table5.Add (this.eRxDrops);
		global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table5[this.eRxDrops]));
		w34.TopAttach = ((uint)(4));
		w34.BottomAttach = ((uint)(5));
		w34.LeftAttach = ((uint)(1));
		w34.RightAttach = ((uint)(2));
		w34.XOptions = ((global::Gtk.AttachOptions)(4));
		w34.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eRxErrs = new global::Gtk.Entry ();
		this.eRxErrs.CanFocus = true;
		this.eRxErrs.Name = "eRxErrs";
		this.eRxErrs.IsEditable = false;
		this.table5.Add (this.eRxErrs);
		global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table5[this.eRxErrs]));
		w35.TopAttach = ((uint)(3));
		w35.BottomAttach = ((uint)(4));
		w35.LeftAttach = ((uint)(1));
		w35.RightAttach = ((uint)(2));
		w35.XOptions = ((global::Gtk.AttachOptions)(4));
		w35.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eRxPackets = new global::Gtk.Entry ();
		this.eRxPackets.CanFocus = true;
		this.eRxPackets.Name = "eRxPackets";
		this.eRxPackets.IsEditable = false;
		this.table5.Add (this.eRxPackets);
		global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table5[this.eRxPackets]));
		w36.TopAttach = ((uint)(2));
		w36.BottomAttach = ((uint)(3));
		w36.LeftAttach = ((uint)(1));
		w36.RightAttach = ((uint)(2));
		w36.XOptions = ((global::Gtk.AttachOptions)(4));
		w36.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eTxBytes = new global::Gtk.Entry ();
		this.eTxBytes.CanFocus = true;
		this.eTxBytes.Name = "eTxBytes";
		this.eTxBytes.IsEditable = false;
		this.table5.Add (this.eTxBytes);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table5[this.eTxBytes]));
		w37.TopAttach = ((uint)(5));
		w37.BottomAttach = ((uint)(6));
		w37.LeftAttach = ((uint)(1));
		w37.RightAttach = ((uint)(2));
		w37.XOptions = ((global::Gtk.AttachOptions)(4));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eTxDrops = new global::Gtk.Entry ();
		this.eTxDrops.CanFocus = true;
		this.eTxDrops.Name = "eTxDrops";
		this.eTxDrops.IsEditable = false;
		this.table5.Add (this.eTxDrops);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table5[this.eTxDrops]));
		w38.TopAttach = ((uint)(8));
		w38.BottomAttach = ((uint)(9));
		w38.LeftAttach = ((uint)(1));
		w38.RightAttach = ((uint)(2));
		w38.XOptions = ((global::Gtk.AttachOptions)(4));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eTxErrs = new global::Gtk.Entry ();
		this.eTxErrs.CanFocus = true;
		this.eTxErrs.Name = "eTxErrs";
		this.eTxErrs.IsEditable = false;
		this.table5.Add (this.eTxErrs);
		global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table5[this.eTxErrs]));
		w39.TopAttach = ((uint)(7));
		w39.BottomAttach = ((uint)(8));
		w39.LeftAttach = ((uint)(1));
		w39.RightAttach = ((uint)(2));
		w39.XOptions = ((global::Gtk.AttachOptions)(4));
		w39.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.eTxPackets = new global::Gtk.Entry ();
		this.eTxPackets.CanFocus = true;
		this.eTxPackets.Name = "eTxPackets";
		this.eTxPackets.IsEditable = false;
		this.table5.Add (this.eTxPackets);
		global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table5[this.eTxPackets]));
		w40.TopAttach = ((uint)(6));
		w40.BottomAttach = ((uint)(7));
		w40.LeftAttach = ((uint)(1));
		w40.RightAttach = ((uint)(2));
		w40.XOptions = ((global::Gtk.AttachOptions)(4));
		w40.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label15 = new global::Gtk.Label ();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Interface :");
		this.table5.Add (this.label15);
		global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table5[this.label15]));
		w41.XOptions = ((global::Gtk.AttachOptions)(4));
		w41.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label16 = new global::Gtk.Label ();
		this.label16.Name = "label16";
		this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("RxBytes :");
		this.table5.Add (this.label16);
		global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table5[this.label16]));
		w42.TopAttach = ((uint)(1));
		w42.BottomAttach = ((uint)(2));
		w42.XOptions = ((global::Gtk.AttachOptions)(4));
		w42.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label17 = new global::Gtk.Label ();
		this.label17.Name = "label17";
		this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("RxPackets :");
		this.table5.Add (this.label17);
		global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table5[this.label17]));
		w43.TopAttach = ((uint)(2));
		w43.BottomAttach = ((uint)(3));
		w43.XOptions = ((global::Gtk.AttachOptions)(4));
		w43.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label18 = new global::Gtk.Label ();
		this.label18.Name = "label18";
		this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("RxErrs :");
		this.table5.Add (this.label18);
		global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table5[this.label18]));
		w44.TopAttach = ((uint)(3));
		w44.BottomAttach = ((uint)(4));
		w44.XOptions = ((global::Gtk.AttachOptions)(4));
		w44.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label19 = new global::Gtk.Label ();
		this.label19.Name = "label19";
		this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("RxDrops :");
		this.table5.Add (this.label19);
		global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table5[this.label19]));
		w45.TopAttach = ((uint)(4));
		w45.BottomAttach = ((uint)(5));
		w45.XOptions = ((global::Gtk.AttachOptions)(4));
		w45.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label20 = new global::Gtk.Label ();
		this.label20.Name = "label20";
		this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("TxBytes :");
		this.table5.Add (this.label20);
		global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table5[this.label20]));
		w46.TopAttach = ((uint)(5));
		w46.BottomAttach = ((uint)(6));
		w46.XOptions = ((global::Gtk.AttachOptions)(4));
		w46.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label21 = new global::Gtk.Label ();
		this.label21.Name = "label21";
		this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("TxPackets :");
		this.table5.Add (this.label21);
		global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table5[this.label21]));
		w47.TopAttach = ((uint)(6));
		w47.BottomAttach = ((uint)(7));
		w47.XOptions = ((global::Gtk.AttachOptions)(4));
		w47.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label22 = new global::Gtk.Label ();
		this.label22.Name = "label22";
		this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("TxErrs :");
		this.table5.Add (this.label22);
		global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table5[this.label22]));
		w48.TopAttach = ((uint)(7));
		w48.BottomAttach = ((uint)(8));
		w48.XOptions = ((global::Gtk.AttachOptions)(4));
		w48.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.label23 = new global::Gtk.Label ();
		this.label23.Name = "label23";
		this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("TxDrops :");
		this.table5.Add (this.label23);
		global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table5[this.label23]));
		w49.TopAttach = ((uint)(8));
		w49.BottomAttach = ((uint)(9));
		w49.XOptions = ((global::Gtk.AttachOptions)(4));
		w49.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment2.Add (this.table5);
		this.frame4.Add (this.GtkAlignment2);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Interface statistics</b>");
		this.GtkLabel3.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel3;
		this.table1.Add (this.frame4);
		global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1[this.frame4]));
		w52.TopAttach = ((uint)(4));
		w52.BottomAttach = ((uint)(5));
		w52.XOptions = ((global::Gtk.AttachOptions)(4));
		w52.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("URI :");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
		w53.XOptions = ((global::Gtk.AttachOptions)(4));
		w53.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label14 = new global::Gtk.Label ();
		this.label14.Name = "label14";
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Domain :");
		this.table1.Add (this.label14);
		global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table1[this.label14]));
		w54.TopAttach = ((uint)(2));
		w54.BottomAttach = ((uint)(3));
		w54.XOptions = ((global::Gtk.AttachOptions)(4));
		w54.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add (this.table1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 546;
		this.DefaultHeight = 598;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.cbInterface.Changed += new global::System.EventHandler (this.OnCbInterfaceChanged);
		this.cbBlockDevice.Changed += new global::System.EventHandler (this.OnCbBlockDeviceChanged);
		this.cbDomains.Changed += new global::System.EventHandler (this.OnCbDomainsChanged);
		this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}

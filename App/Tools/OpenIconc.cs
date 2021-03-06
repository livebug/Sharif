using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Tools
{
    public enum OpenIconc
    {
        [Description("Zoom-Out")]
        ZoomOut,
        [Description("Zoom-In")]
        ZoomIn,
        [Description("Yen")]
        Yen,
        [Description("X")]
        X,
        [Description("Wrench")]
        Wrench,
        [Description("Wifi")]
        Wifi,
        [Description("Warning")]
        Warning,
        [Description("Volume-Off")]
        VolumeOff,
        [Description("Volume-Low")]
        VolumeLow,
        [Description("Volume-High")]
        VolumeHigh,
        [Description("Video")]
        Video,
        [Description("Vertical-Align-Top")]
        VerticalAlignTop,
        [Description("Vertical-Align-Center")]
        VerticalAlignCenter,
        [Description("Vertical-Align-Bottom")]
        VerticalAlignBottom,
        [Description("Underline")]
        Underline,
        [Description("Trash")]
        Trash,
        [Description("Transfer")]
        Transfer,
        [Description("Timer")]
        Timer,
        [Description("Thumb-Up")]
        ThumbUp,
        [Description("Thumb-Down")]
        ThumbDown,
        [Description("Text")]
        Text,
        [Description("Terminal")]
        Terminal,
        [Description("Task")]
        Task,
        [Description("Target")]
        Target,
        [Description("Tags")]
        Tags,
        [Description("Tag")]
        Tag,
        [Description("Tablet")]
        Tablet,
        [Description("Sun")]
        Sun,
        [Description("Star")]
        Star,
        [Description("Spreadsheet")]
        Spreadsheet,
        [Description("Sort-Descending")]
        SortDescending,
        [Description("Sort-Ascending")]
        SortAscending,
        [Description("Signpost")]
        Signpost,
        [Description("Signal")]
        Signal,
        [Description("Shield")]
        Shield,
        [Description("Share")]
        Share,
        [Description("Share-Boxed")]
        ShareBoxed,
        [Description("Script")]
        Script,
        [Description("Rss")]
        Rss,
        [Description("Rss-Alt")]
        RssAlt,
        [Description("Resize-Width")]
        ResizeWidth,
        [Description("Resize-Height")]
        ResizeHeight,
        [Description("Resize-Both")]
        ResizeBoth,
        [Description("Reload")]
        Reload,
        [Description("Random")]
        Random,
        [Description("Rain")]
        Rain,
        [Description("Question-Mark")]
        QuestionMark,
        [Description("Puzzle-Piece")]
        PuzzlePiece,
        [Description("Pulse")]
        Pulse,
        [Description("Project")]
        Project,
        [Description("Print")]
        Print,
        [Description("Power-Standby")]
        PowerStandby,
        [Description("Plus")]
        Plus,
        [Description("Play-Circle")]
        PlayCircle,
        [Description("Pin")]
        Pin,
        [Description("Pie-Chart")]
        PieChart,
        [Description("Phone")]
        Phone,
        [Description("Person")]
        Person,
        [Description("People")]
        People,
        [Description("Pencil")]
        Pencil,
        [Description("Paperclip")]
        Paperclip,
        [Description("Musical-Note")]
        MusicalNote,
        [Description("Move")]
        Move,
        [Description("Moon")]
        Moon,
        [Description("Monitor")]
        Monitor,
        [Description("Minus")]
        Minus,
        [Description("Microphone")]
        Microphone,
        [Description("Menu")]
        Menu,
        [Description("Medical-Cross")]
        MedicalCross,
        [Description("Media-Stop")]
        MediaStop,
        [Description("Media-Step-Forward")]
        MediaStepForward,
        [Description("Media-Step-Backward")]
        MediaStepBackward,
        [Description("Media-Skip-Forward")]
        MediaSkipForward,
        [Description("Media-Skip-Backward")]
        MediaSkipBackward,
        [Description("Media-Record")]
        MediaRecord,
        [Description("Media-Play")]
        MediaPlay,
        [Description("Media-Pause")]
        MediaPause,
        [Description("Map")]
        Map,
        [Description("Map-Marker")]
        MapMarker,
        [Description("Magnifying-Glass")]
        MagnifyingGlass,
        [Description("Loop")]
        Loop,
        [Description("Loop-Square")]
        LoopSquare,
        [Description("Loop-Circular")]
        LoopCircular,
        [Description("Lock-Unlocked")]
        LockUnlocked,
        [Description("Lock-Locked")]
        LockLocked,
        [Description("Location")]
        Location,
        [Description("List")]
        List,
        [Description("List-Rich")]
        ListRich,
        [Description("Link-Intact")]
        LinkIntact,
        [Description("Link-Broken")]
        LinkBroken,
        [Description("Lightbulb")]
        Lightbulb,
        [Description("Layers")]
        Layers,
        [Description("Laptop")]
        Laptop,
        [Description("Key")]
        Key,
        [Description("Justify-Right")]
        JustifyRight,
        [Description("Justify-Left")]
        JustifyLeft,
        [Description("Justify-Center")]
        JustifyCenter,
        [Description("Italic")]
        Italic,
        [Description("Info")]
        Info,
        [Description("Infinity")]
        Infinity,
        [Description("Inbox")]
        Inbox,
        [Description("Image")]
        Image,
        [Description("Home")]
        Home,
        [Description("Heart")]
        Heart,
        [Description("Headphones")]
        Headphones,
        [Description("Header")]
        Header,
        [Description("Hard-Drive")]
        HardDrive,
        [Description("Grid-Two-Up")]
        GridTwoUp,
        [Description("Grid-Three-Up")]
        GridThreeUp,
        [Description("Grid-Four-Up")]
        GridFourUp,
        [Description("Graph")]
        Graph,
        [Description("Globe")]
        Globe,
        [Description("Fullscreen-Exit")]
        FullscreenExit,
        [Description("Fullscreen-Enter")]
        FullscreenEnter,
        [Description("Fork")]
        Fork,
        [Description("Folder")]
        Folder,
        [Description("Flash")]
        Flash,
        [Description("Flag")]
        Flag,
        [Description("Fire")]
        Fire,
        [Description("File")]
        File,
        [Description("Eyedropper")]
        Eyedropper,
        [Description("Eye")]
        Eye,
        [Description("External-Link")]
        ExternalLink,
        [Description("Expand-Up")]
        ExpandUp,
        [Description("Expand-Right")]
        ExpandRight,
        [Description("Expand-Left")]
        ExpandLeft,
        [Description("Expand-Down")]
        ExpandDown,
        [Description("Excerpt")]
        Excerpt,
        [Description("Euro")]
        Euro,
        [Description("Envelope-Open")]
        EnvelopeOpen,
        [Description("Envelope-Closed")]
        EnvelopeClosed,
        [Description("Ellipses")]
        Ellipses,
        [Description("Elevator")]
        Elevator,
        [Description("Eject")]
        Eject,
        [Description("Droplet")]
        Droplet,
        [Description("Double-Quote-Serif-Right")]
        DoubleQuoteSerifRight,
        [Description("Double-Quote-Serif-Left")]
        DoubleQuoteSerifLeft,
        [Description("Double-Quote-Sans-Right")]
        DoubleQuoteSansRight,
        [Description("Double-Quote-Sans-Left")]
        DoubleQuoteSansLeft,
        [Description("Dollar")]
        Dollar,
        [Description("Document")]
        Document,
        [Description("Dial")]
        Dial,
        [Description("Delete")]
        Delete,
        [Description("Data-Transfer-Upload")]
        DataTransferUpload,
        [Description("Data-Transfer-Download")]
        DataTransferDownload,
        [Description("Dashboard")]
        Dashboard,
        [Description("Crop")]
        Crop,
        [Description("Credit-Card")]
        CreditCard,
        [Description("Copywriting")]
        Copywriting,
        [Description("Contrast")]
        Contrast,
        [Description("Compass")]
        Compass,
        [Description("Comment-Square")]
        CommentSquare,
        [Description("Command")]
        Command,
        [Description("Collapse-Up")]
        CollapseUp,
        [Description("Collapse-Right")]
        CollapseRight,
        [Description("Collapse-Left")]
        CollapseLeft,
        [Description("Collapse-Down")]
        CollapseDown,
        [Description("Cog")]
        Cog,
        [Description("Code")]
        Code,
        [Description("Cloudy")]
        Cloudy,
        [Description("Cloud")]
        Cloud,
        [Description("Cloud-Upload")]
        CloudUpload,
        [Description("Cloud-Download")]
        CloudDownload,
        [Description("Clock")]
        Clock,
        [Description("Clipboard")]
        Clipboard,
        [Description("Circle-X")]
        CircleX,
        [Description("Circle-Check")]
        CircleCheck,
        [Description("Chevron-Top")]
        ChevronTop,
        [Description("Chevron-Right")]
        ChevronRight,
        [Description("Chevron-Left")]
        ChevronLeft,
        [Description("Chevron-Bottom")]
        ChevronBottom,
        [Description("Check")]
        Check,
        [Description("Chat")]
        Chat,
        [Description("Cart")]
        Cart,
        [Description("Caret-Top")]
        CaretTop,
        [Description("Caret-Right")]
        CaretRight,
        [Description("Caret-Left")]
        CaretLeft,
        [Description("Caret-Bottom")]
        CaretBottom,
        [Description("Camera-Slr")]
        CameraSlr,
        [Description("Calendar")]
        Calendar,
        [Description("Calculator")]
        Calculator,
        [Description("Bullhorn")]
        Bullhorn,
        [Description("Bug")]
        Bug,
        [Description("Brush")]
        Brush,
        [Description("Browser")]
        Browser,
        [Description("British-Pound")]
        BritishPound,
        [Description("Briefcase")]
        Briefcase,
        [Description("Box")]
        Box,
        [Description("Bookmark")]
        Bookmark,
        [Description("Book")]
        Book,
        [Description("Bolt")]
        Bolt,
        [Description("Bold")]
        Bold,
        [Description("Bluetooth")]
        Bluetooth,
        [Description("Bell")]
        Bell,
        [Description("Beaker")]
        Beaker,
        [Description("Battery-Full")]
        BatteryFull,
        [Description("Battery-Empty")]
        BatteryEmpty,
        [Description("Basket")]
        Basket,
        [Description("Bar-Chart")]
        BarChart,
        [Description("Ban")]
        Ban,
        [Description("Badge")]
        Badge,
        [Description("Audio")]
        Audio,
        [Description("Audio-Spectrum")]
        AudioSpectrum,
        [Description("Arrow-Top")]
        ArrowTop,
        [Description("Arrow-Thick-Top")]
        ArrowThickTop,
        [Description("Arrow-Thick-Right")]
        ArrowThickRight,
        [Description("Arrow-Thick-Left")]
        ArrowThickLeft,
        [Description("Arrow-Thick-Bottom")]
        ArrowThickBottom,
        [Description("Arrow-Right")]
        ArrowRight,
        [Description("Arrow-Left")]
        ArrowLeft,
        [Description("Arrow-Circle-Top")]
        ArrowCircleTop,
        [Description("Arrow-Circle-Right")]
        ArrowCircleRight,
        [Description("Arrow-Circle-Left")]
        ArrowCircleLeft,
        [Description("Arrow-Circle-Bottom")]
        ArrowCircleBottom,
        [Description("Arrow-Bottom")]
        ArrowBottom,
        [Description("Aperture")]
        Aperture,
        [Description("Align-Right")]
        AlignRight,
        [Description("Align-Left")]
        AlignLeft,
        [Description("Align-Center")]
        AlignCenter,
        [Description("Action-Undo")]
        ActionUndo,
        [Description("Action-Redo")]
        ActionRedo,
        [Description("Account-Logout")]
        AccountLogout,
        [Description("Account-Login")]
        AccountLogin
    }
}

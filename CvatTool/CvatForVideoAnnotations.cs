
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class annotations
{

    private decimal versionField;

    private annotationsMeta metaField;

    private annotationsTrack[] trackField;

    /// <remarks/>
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public annotationsMeta meta
    {
        get
        {
            return this.metaField;
        }
        set
        {
            this.metaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("track")]
    public annotationsTrack[] track
    {
        get
        {
            return this.trackField;
        }
        set
        {
            this.trackField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMeta
{

    private annotationsMetaTask taskField;

    private string dumpedField;

    /// <remarks/>
    public annotationsMetaTask task
    {
        get
        {
            return this.taskField;
        }
        set
        {
            this.taskField = value;
        }
    }

    /// <remarks/>
    public string dumped
    {
        get
        {
            return this.dumpedField;
        }
        set
        {
            this.dumpedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMetaTask
{

    private ushort idField;

    private string nameField;

    private uint sizeField;

    private string modeField;

    private byte overlapField;

    private object bugtrackerField;

    private string createdField;

    private string updatedField;

    private byte start_frameField;

    private uint stop_frameField;

    private object frame_filterField;

    private annotationsMetaTaskLabel[] labelsField;

    private annotationsMetaTaskSegments segmentsField;

    private annotationsMetaTaskOwner ownerField;

    private object assigneeField;

    /// <remarks/>
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public uint size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    public string mode
    {
        get
        {
            return this.modeField;
        }
        set
        {
            this.modeField = value;
        }
    }

    /// <remarks/>
    public byte overlap
    {
        get
        {
            return this.overlapField;
        }
        set
        {
            this.overlapField = value;
        }
    }

    /// <remarks/>
    public object bugtracker
    {
        get
        {
            return this.bugtrackerField;
        }
        set
        {
            this.bugtrackerField = value;
        }
    }

    /// <remarks/>
    public string created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }

    /// <remarks/>
    public string updated
    {
        get
        {
            return this.updatedField;
        }
        set
        {
            this.updatedField = value;
        }
    }

    /// <remarks/>
    public byte start_frame
    {
        get
        {
            return this.start_frameField;
        }
        set
        {
            this.start_frameField = value;
        }
    }

    /// <remarks/>
    public uint stop_frame
    {
        get
        {
            return this.stop_frameField;
        }
        set
        {
            this.stop_frameField = value;
        }
    }

    /// <remarks/>
    public object frame_filter
    {
        get
        {
            return this.frame_filterField;
        }
        set
        {
            this.frame_filterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable = false)]
    public annotationsMetaTaskLabel[] labels
    {
        get
        {
            return this.labelsField;
        }
        set
        {
            this.labelsField = value;
        }
    }

    /// <remarks/>
    public annotationsMetaTaskSegments segments
    {
        get
        {
            return this.segmentsField;
        }
        set
        {
            this.segmentsField = value;
        }
    }

    /// <remarks/>
    public annotationsMetaTaskOwner owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }

    /// <remarks/>
    public object assignee
    {
        get
        {
            return this.assigneeField;
        }
        set
        {
            this.assigneeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMetaTaskLabel
{

    private string nameField;

    private string colorField;

    private object attributesField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public object attributes
    {
        get
        {
            return this.attributesField;
        }
        set
        {
            this.attributesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMetaTaskSegments
{

    private annotationsMetaTaskSegmentsSegment segmentField;

    /// <remarks/>
    public annotationsMetaTaskSegmentsSegment segment
    {
        get
        {
            return this.segmentField;
        }
        set
        {
            this.segmentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMetaTaskSegmentsSegment
{

    private ushort idField;

    private byte startField;

    private uint stopField;

    private string urlField;

    /// <remarks/>
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public byte start
    {
        get
        {
            return this.startField;
        }
        set
        {
            this.startField = value;
        }
    }

    /// <remarks/>
    public uint stop
    {
        get
        {
            return this.stopField;
        }
        set
        {
            this.stopField = value;
        }
    }

    /// <remarks/>
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsMetaTaskOwner
{

    private string usernameField;

    private string emailField;

    /// <remarks/>
    public string username
    {
        get
        {
            return this.usernameField;
        }
        set
        {
            this.usernameField = value;
        }
    }

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsTrack
{

    private annotationsTrackBox[] boxField;

    private ushort idField;

    private string labelField;

    private string sourceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("box")]
    public annotationsTrackBox[] box
    {
        get
        {
            return this.boxField;
        }
        set
        {
            this.boxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class annotationsTrackBox
{

    private uint frameField;

    private byte outsideField;

    private byte occludedField;

    private byte keyframeField;

    private decimal xtlField;

    private decimal ytlField;

    private decimal xbrField;

    private decimal ybrField;

    private byte z_orderField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint frame
    {
        get
        {
            return this.frameField;
        }
        set
        {
            this.frameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte outside
    {
        get
        {
            return this.outsideField;
        }
        set
        {
            this.outsideField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte occluded
    {
        get
        {
            return this.occludedField;
        }
        set
        {
            this.occludedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte keyframe
    {
        get
        {
            return this.keyframeField;
        }
        set
        {
            this.keyframeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal xtl
    {
        get
        {
            return this.xtlField;
        }
        set
        {
            this.xtlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ytl
    {
        get
        {
            return this.ytlField;
        }
        set
        {
            this.ytlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal xbr
    {
        get
        {
            return this.xbrField;
        }
        set
        {
            this.xbrField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ybr
    {
        get
        {
            return this.ybrField;
        }
        set
        {
            this.ybrField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte z_order
    {
        get
        {
            return this.z_orderField;
        }
        set
        {
            this.z_orderField = value;
        }
    }
}


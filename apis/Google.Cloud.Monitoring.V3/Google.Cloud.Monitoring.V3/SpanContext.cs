// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/span_context.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/span_context.proto</summary>
  public static partial class SpanContextReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/span_context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpanContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvbW9uaXRvcmluZy92My9zcGFuX2NvbnRleHQucHJvdG8SFGdv",
            "b2dsZS5tb25pdG9yaW5nLnYzIiAKC1NwYW5Db250ZXh0EhEKCXNwYW5fbmFt",
            "ZRgBIAEoCUKoAQoYY29tLmdvb2dsZS5tb25pdG9yaW5nLnYzQhBTcGFuQ29u",
            "dGV4dFByb3RvUAFaPmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvbW9uaXRvcmluZy92Mzttb25pdG9yaW5nqgIaR29vZ2xlLkNsb3Vk",
            "Lk1vbml0b3JpbmcuVjPKAhpHb29nbGVcQ2xvdWRcTW9uaXRvcmluZ1xWM2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Monitoring.V3.SpanContext), global::Google.Cloud.Monitoring.V3.SpanContext.Parser, new[]{ "SpanName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The context of a span, attached to google.api.Distribution.Exemplars
  /// in google.api.Distribution values during aggregation.
  ///
  /// It contains the name of a span with format:
  ///     projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
  /// </summary>
  public sealed partial class SpanContext : pb::IMessage<SpanContext> {
    private static readonly pb::MessageParser<SpanContext> _parser = new pb::MessageParser<SpanContext>(() => new SpanContext());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpanContext> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Monitoring.V3.SpanContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpanContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpanContext(SpanContext other) : this() {
      spanName_ = other.spanName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpanContext Clone() {
      return new SpanContext(this);
    }

    /// <summary>Field number for the "span_name" field.</summary>
    public const int SpanNameFieldNumber = 1;
    private string spanName_ = "";
    /// <summary>
    /// The resource name of the span in the following format:
    ///
    ///     projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
    ///
    /// [TRACE_ID] is a unique identifier for a trace within a project;
    /// it is a 32-character hexadecimal encoding of a 16-byte array.
    ///
    /// [SPAN_ID] is a unique identifier for a span within a trace; it
    /// is a 16-character hexadecimal encoding of an 8-byte array.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpanName {
      get { return spanName_; }
      set {
        spanName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpanContext);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpanContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpanName != other.SpanName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SpanName.Length != 0) hash ^= SpanName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SpanName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SpanName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SpanName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpanName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpanContext other) {
      if (other == null) {
        return;
      }
      if (other.SpanName.Length != 0) {
        SpanName = other.SpanName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SpanName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

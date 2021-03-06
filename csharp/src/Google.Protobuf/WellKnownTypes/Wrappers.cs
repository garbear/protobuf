// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/wrappers.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Wrappers {

    #region Descriptor
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Wrappers() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8SD2dvb2dsZS5wcm90", 
            "b2J1ZiIcCgtEb3VibGVWYWx1ZRINCgV2YWx1ZRgBIAEoASIbCgpGbG9hdFZh", 
            "bHVlEg0KBXZhbHVlGAEgASgCIhsKCkludDY0VmFsdWUSDQoFdmFsdWUYASAB", 
            "KAMiHAoLVUludDY0VmFsdWUSDQoFdmFsdWUYASABKAQiGwoKSW50MzJWYWx1", 
            "ZRINCgV2YWx1ZRgBIAEoBSIcCgtVSW50MzJWYWx1ZRINCgV2YWx1ZRgBIAEo", 
            "DSIaCglCb29sVmFsdWUSDQoFdmFsdWUYASABKAgiHAoLU3RyaW5nVmFsdWUS", 
            "DQoFdmFsdWUYASABKAkiGwoKQnl0ZXNWYWx1ZRINCgV2YWx1ZRgBIAEoDEJN", 
            "ChNjb20uZ29vZ2xlLnByb3RvYnVmQg1XcmFwcGVyc1Byb3RvUAGiAgNHUEKq", 
            "Ah5Hb29nbGUuUHJvdG9idWYuV2VsbEtub3duVHlwZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.DoubleValue), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.FloatValue), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Int64Value), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.UInt64Value), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Int32Value), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.UInt32Value), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.BoolValue), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.StringValue), new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.BytesValue), new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DoubleValue : pb::IMessage<DoubleValue> {
    private static readonly pb::MessageParser<DoubleValue> _parser = new pb::MessageParser<DoubleValue>(() => new DoubleValue());
    public static pb::MessageParser<DoubleValue> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DoubleValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DoubleValue(DoubleValue other) : this() {
      value_ = other.value_;
    }

    public DoubleValue Clone() {
      return new DoubleValue(this);
    }

    public const int ValueFieldNumber = 1;
    private double value_;
    public double Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DoubleValue);
    }

    public bool Equals(DoubleValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0D) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(DoubleValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0D) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 9: {
            Value = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FloatValue : pb::IMessage<FloatValue> {
    private static readonly pb::MessageParser<FloatValue> _parser = new pb::MessageParser<FloatValue>(() => new FloatValue());
    public static pb::MessageParser<FloatValue> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FloatValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FloatValue(FloatValue other) : this() {
      value_ = other.value_;
    }

    public FloatValue Clone() {
      return new FloatValue(this);
    }

    public const int ValueFieldNumber = 1;
    private float value_;
    public float Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FloatValue);
    }

    public bool Equals(FloatValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0F) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(FloatValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0F) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 13: {
            Value = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Int64Value : pb::IMessage<Int64Value> {
    private static readonly pb::MessageParser<Int64Value> _parser = new pb::MessageParser<Int64Value>(() => new Int64Value());
    public static pb::MessageParser<Int64Value> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Int64Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Int64Value(Int64Value other) : this() {
      value_ = other.value_;
    }

    public Int64Value Clone() {
      return new Int64Value(this);
    }

    public const int ValueFieldNumber = 1;
    private long value_;
    public long Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Int64Value);
    }

    public bool Equals(Int64Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0L) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Value);
      }
      return size;
    }

    public void MergeFrom(Int64Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0L) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Value = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UInt64Value : pb::IMessage<UInt64Value> {
    private static readonly pb::MessageParser<UInt64Value> _parser = new pb::MessageParser<UInt64Value>(() => new UInt64Value());
    public static pb::MessageParser<UInt64Value> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UInt64Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UInt64Value(UInt64Value other) : this() {
      value_ = other.value_;
    }

    public UInt64Value Clone() {
      return new UInt64Value(this);
    }

    public const int ValueFieldNumber = 1;
    private ulong value_;
    public ulong Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UInt64Value);
    }

    public bool Equals(UInt64Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0UL) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Value);
      }
      return size;
    }

    public void MergeFrom(UInt64Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0UL) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Value = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Int32Value : pb::IMessage<Int32Value> {
    private static readonly pb::MessageParser<Int32Value> _parser = new pb::MessageParser<Int32Value>(() => new Int32Value());
    public static pb::MessageParser<Int32Value> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Int32Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Int32Value(Int32Value other) : this() {
      value_ = other.value_;
    }

    public Int32Value Clone() {
      return new Int32Value(this);
    }

    public const int ValueFieldNumber = 1;
    private int value_;
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Int32Value);
    }

    public bool Equals(Int32Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      return size;
    }

    public void MergeFrom(Int32Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Value = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UInt32Value : pb::IMessage<UInt32Value> {
    private static readonly pb::MessageParser<UInt32Value> _parser = new pb::MessageParser<UInt32Value>(() => new UInt32Value());
    public static pb::MessageParser<UInt32Value> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UInt32Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UInt32Value(UInt32Value other) : this() {
      value_ = other.value_;
    }

    public UInt32Value Clone() {
      return new UInt32Value(this);
    }

    public const int ValueFieldNumber = 1;
    private uint value_;
    public uint Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UInt32Value);
    }

    public bool Equals(UInt32Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Value);
      }
      return size;
    }

    public void MergeFrom(UInt32Value other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Value = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BoolValue : pb::IMessage<BoolValue> {
    private static readonly pb::MessageParser<BoolValue> _parser = new pb::MessageParser<BoolValue>(() => new BoolValue());
    public static pb::MessageParser<BoolValue> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BoolValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BoolValue(BoolValue other) : this() {
      value_ = other.value_;
    }

    public BoolValue Clone() {
      return new BoolValue(this);
    }

    public const int ValueFieldNumber = 1;
    private bool value_;
    public bool Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as BoolValue);
    }

    public bool Equals(BoolValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value != false) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != false) {
        output.WriteRawTag(8);
        output.WriteBool(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(BoolValue other) {
      if (other == null) {
        return;
      }
      if (other.Value != false) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Value = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class StringValue : pb::IMessage<StringValue> {
    private static readonly pb::MessageParser<StringValue> _parser = new pb::MessageParser<StringValue>(() => new StringValue());
    public static pb::MessageParser<StringValue> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[7]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public StringValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    public StringValue(StringValue other) : this() {
      value_ = other.value_;
    }

    public StringValue Clone() {
      return new StringValue(this);
    }

    public const int ValueFieldNumber = 1;
    private string value_ = "";
    public string Value {
      get { return value_; }
      set {
        value_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as StringValue);
    }

    public bool Equals(StringValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    public void MergeFrom(StringValue other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BytesValue : pb::IMessage<BytesValue> {
    private static readonly pb::MessageParser<BytesValue> _parser = new pb::MessageParser<BytesValue>(() => new BytesValue());
    public static pb::MessageParser<BytesValue> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Wrappers.Descriptor.MessageTypes[8]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BytesValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BytesValue(BytesValue other) : this() {
      value_ = other.value_;
    }

    public BytesValue Clone() {
      return new BytesValue(this);
    }

    public const int ValueFieldNumber = 1;
    private pb::ByteString value_ = pb::ByteString.Empty;
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as BytesValue);
    }

    public bool Equals(BytesValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      return size;
    }

    public void MergeFrom(BytesValue other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 10: {
            Value = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

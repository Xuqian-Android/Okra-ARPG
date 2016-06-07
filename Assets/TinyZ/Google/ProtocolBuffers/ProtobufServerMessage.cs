// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ProtobufServerMessage {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static ProtobufServerMessage() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ServerMessage : pb::ExtendableMessageLite<ServerMessage, ServerMessage.Builder> {
    private ServerMessage() { }
    private static readonly ServerMessage defaultInstance = new ServerMessage().MakeReadOnly();
    private static readonly string[] _serverMessageFieldNames = new string[] { "msgId" };
    private static readonly uint[] _serverMessageFieldTags = new uint[] { 10 };
    public static ServerMessage DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ServerMessage DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override ServerMessage ThisMessage {
      get { return this; }
    }
    
    public const int MsgIdFieldNumber = 1;
    private bool hasMsgId;
    private string msgId_ = "";
    public bool HasMsgId {
      get { return hasMsgId; }
    }
    public string MsgId {
      get { return msgId_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasMsgId) return false;
        if (!ExtensionsAreInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _serverMessageFieldNames;
      pb::ExtendableMessageLite<ServerMessage, ServerMessage.Builder>.ExtensionWriter extensionWriter = CreateExtensionWriter(this);
      if (hasMsgId) {
        output.WriteString(1, field_names[0], MsgId);
      }
      extensionWriter.WriteUntil(256, output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasMsgId) {
          size += pb::CodedOutputStream.ComputeStringSize(1, MsgId);
        }
        size += ExtensionsSerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasMsgId) hash ^= msgId_.GetHashCode();
      hash ^= base.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      ServerMessage other = obj as ServerMessage;
      if (other == null) return false;
      if (hasMsgId != other.hasMsgId || (hasMsgId && !msgId_.Equals(other.msgId_))) return false;
      if (!base.Equals(other)) return false;
      return true;
    }
    
    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("msgId", hasMsgId, msgId_, writer);
      base.PrintTo(writer);
    }
    #endregion
    
    public static ServerMessage ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ServerMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ServerMessage ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ServerMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ServerMessage ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ServerMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ServerMessage ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ServerMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ServerMessage ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ServerMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ServerMessage MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ServerMessage prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::ExtendableBuilderLite<ServerMessage, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ServerMessage cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private ServerMessage result;
      
      private ServerMessage PrepareBuilder() {
        if (resultIsReadOnly) {
          ServerMessage original = result;
          result = new ServerMessage();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override ServerMessage MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override ServerMessage DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.ServerMessage.DefaultInstance; }
      }
      
      public override ServerMessage BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is ServerMessage) {
          return MergeFrom((ServerMessage) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ServerMessage other) {
        if (other == global::Google.ProtocolBuffers.ServerMessage.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasMsgId) {
          MsgId = other.MsgId;
        }
          this.MergeExtensionFields(other);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_serverMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _serverMessageFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasMsgId = input.ReadString(ref result.msgId_);
              break;
            }
          }
        }
        
        return this;
      }
      
      
      public bool HasMsgId {
        get { return result.hasMsgId; }
      }
      public string MsgId {
        get { return result.MsgId; }
        set { SetMsgId(value); }
      }
      public Builder SetMsgId(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMsgId = true;
        result.msgId_ = value;
        return this;
      }
      public Builder ClearMsgId() {
        PrepareBuilder();
        result.hasMsgId = false;
        result.msgId_ = "";
        return this;
      }
    }
    static ServerMessage() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.ProtobufServerMessage.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
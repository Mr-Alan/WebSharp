﻿using System;
using System.Threading.Tasks;
using WebSharpJs.Script;

namespace WebSharpJs.Electron
{
    [ScriptableType]
    public struct FileFilter
    {
        [ScriptableMember(ScriptAlias = "name")]
        public string Name { get; set; }
        [ScriptableMember(ScriptAlias = "extensions")]
        public string[] Extensions { get; set; }

        public override string ToString()
        {
            return $"FileFilter {{ Name: {Name} Extenstions: {Extensions} }}";
        }
    }

    [ScriptableType]
    public class Size
    {
        public static readonly Size Empty = new Size();

        [ScriptableMember(ScriptAlias = "width")]
        public int Width { get; set; }
        [ScriptableMember(ScriptAlias = "height")]
        public int Height { get; set; }

        public Size()
        { }

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Size(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            Width = System.Convert.ToInt32(dict["width"]);
            Height = System.Convert.ToInt32(dict["height"]);
        }

        public override string ToString()
        {
            return $"Size {{ Width: {Width} Height: {Height} }}";
        }
    }

    [ScriptableType]
    public class SizeF
    {
        public static readonly SizeF Empty = new SizeF();

        [ScriptableMember(ScriptAlias = "width")]
        public float Width { get; set; }
        [ScriptableMember(ScriptAlias = "height")]
        public float Height { get; set; }

        public SizeF()
        { }

        public SizeF(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public SizeF(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            Width = System.Convert.ToSingle(dict["width"]);
            Height = System.Convert.ToSingle(dict["height"]);
        }

        public override string ToString()
        {
            return $"Size {{ Width: {Width} Height: {Height} }}";
        }
    }

    [ScriptableType]
    public class Rectangle
    {
        public static readonly Rectangle Empty = new Rectangle(0,0);

        [ScriptableMember(ScriptAlias = "x")]
        public int X { get; set; }
        [ScriptableMember(ScriptAlias = "y")]
        public int Y { get; set; }
        [ScriptableMember(ScriptAlias = "width")]
        public int Width { get; set; }
        [ScriptableMember(ScriptAlias = "height")]
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int x, int y, int width = 0, int height = 0)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }


        public Rectangle(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            X = System.Convert.ToInt32(dict["x"]);
            Y = System.Convert.ToInt32(dict["y"]);
            Width = System.Convert.ToInt32(dict["width"]);
            Height = System.Convert.ToInt32(dict["height"]);
        }

        public override string ToString()
        {
            return $"Rect {{ X: {X} Y: {Y} Width: {Width} Height: {Height} }}";
        }
    }

    [ScriptableType]
    public class RectangleF
    {
        public static readonly RectangleF Empty = new RectangleF();

        [ScriptableMember(ScriptAlias = "x")]
        public float X { get; set; }
        [ScriptableMember(ScriptAlias = "y")]
        public float Y { get; set; }
        [ScriptableMember(ScriptAlias = "width")]
        public float Width { get; set; }
        [ScriptableMember(ScriptAlias = "height")]
        public float Height { get; set; }

        public RectangleF() { }

        public RectangleF(float x, float y, float width = 0, float height = 0)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }


        public RectangleF(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            X = System.Convert.ToSingle(dict["x"]);
            Y = System.Convert.ToSingle(dict["y"]);
            Width = System.Convert.ToSingle(dict["width"]);
            Height = System.Convert.ToSingle(dict["height"]);
        }

        public override string ToString()
        {
            return $"Rect {{ X: {X} Y: {Y} Width: {Width} Height: {Height} }}";
        }
    }

    [ScriptableType]
    public class Point
    {
        public static readonly Point Empty = new Point(0,0);

        [ScriptableMember(ScriptAlias = "x")]
        public int X { get; set; }
        [ScriptableMember(ScriptAlias = "y")]
        public int Y { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            X = System.Convert.ToInt32(dict["x"]);
            Y = System.Convert.ToInt32(dict["y"]);
        }

        public override string ToString()
        {
            return $"Point {{ X: {X} Y: {Y} }}";
        }
    }

    [ScriptableType]
    public class PointF
    {
        public static readonly PointF Empty = new PointF(0,0);

        [ScriptableMember(ScriptAlias = "x")]
        public float X { get; set; }
        [ScriptableMember(ScriptAlias = "y")]
        public float Y { get; set; }

        public PointF(float x, float y)
        {
            X = x;
            Y = y;
        }

        public PointF(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            X = System.Convert.ToSingle(dict["x"]);
            Y = System.Convert.ToSingle(dict["y"]);
        }

        public override string ToString()
        {
            return $"Point {{ X: {X} Y: {Y} }}";
        }
    }

    [ScriptableType]
    public struct DesktopCapturerSource
    {
        [ScriptableMember(ScriptAlias = "id")]
        public string Id { get; set; }
        [ScriptableMember(ScriptAlias = "name")]
        public string Name { get; set; }
        [ScriptableMember(ScriptAlias = "thumbnail")]
        public NativeImage Thumbnail { get; set; }

    }

    [ScriptableType]
    public class Error
    {
        [ScriptableMember(ScriptAlias = "name")]
        public string Name { get; set; }
        [ScriptableMember(ScriptAlias = "message")]
        public string Message { get; set; }
        [ScriptableMember(ScriptAlias = "stack")]
        public string Stack { get; set; }
    }

    [ScriptableType(ScriptableType = ScriptableType.Event)]
    public class Event
    {
        // Set by ScriptObjectCallback to support PreventDefault Event actions.
        // See code for ScriptObjectCallback.
        [ScriptableMember(ScriptAlias = "preventDefault")]
        public Action PreventDefault { get; internal set; }

        [ScriptableMember(ScriptAlias = "sender")]
        public NodeJS.EventEmitter Sender { get; set; }

    }

    [ScriptableType]
    public class IpcMainEvent
    {
        [ScriptableMember(ScriptAlias = "returnValue")]
        public object ReturnValue { get; set; } = string.Empty;
        [ScriptableMember(ScriptAlias = "sender")]
        public WebContents Sender { get; set; }

    }

    [ScriptableType]
    public class IpcRendererEvent
    {
        [ScriptableMember(ScriptAlias = "sender")]
        public IpcRenderer Sender { get; set; }
    }

    [ScriptableType]
    public struct BalloonOptions
    {
        [ScriptableMember(ScriptAlias = "icon")]
        public NativeImage Icon { get; set; }
        [ScriptableMember(ScriptAlias = "title")]
        public string Title { get; set; }
        [ScriptableMember(ScriptAlias = "content")]
        public string Content { get; set; }

    }

    [ScriptableType]
    public class Display
    {
        [ScriptableMember(ScriptAlias = "id")]
        public uint Id { get; set; }
        [ScriptableMember(ScriptAlias = "bounds")]
        public Rectangle Bounds { get; set; }
        [ScriptableMember(ScriptAlias = "workArea")]
        public Rectangle WorkArea { get; set; }
        [ScriptableMember(ScriptAlias = "size")]
        public Size Size { get; set; }
        [ScriptableMember(ScriptAlias = "workAreaSize")]
        public Size WorkAreaSize { get; set; }
        [ScriptableMember(ScriptAlias = "scaleFactor")]
        public float ScaleFactor { get; set; }
        [ScriptableMember(ScriptAlias = "rotation")]
        public float Rotation { get; set; }
        [ScriptableMember(ScriptAlias = "touchSupport", EnumValue = ConvertEnum.ToLower)]
        public TouchSupport TouchSupport { get; set; }
    }
    [ScriptableType]
    public struct ThumbarButton
    {
        [ScriptableMember(ScriptAlias = "click")]
        public ScriptObjectCallback Click { get; set; }
        [ScriptableMember(ScriptAlias = "flags")]
        public string[] Flags { get; set; }
        [ScriptableMember(ScriptAlias = "icon")]
        public NativeImage Icon { get; set; }
        [ScriptableMember(ScriptAlias = "tooltip")]
        public string Tooltip { get; set; }
    }

    [ScriptableType]
    public class Normal
    {
        public static readonly Normal Empty = new Normal();

        [ScriptableMember(ScriptAlias = "width")]
        public int Width { get; set; }
        [ScriptableMember(ScriptAlias = "height")]
        public int Height { get; set; }

        public Normal()
        { }

        public Normal(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Normal(dynamic obj)
        {
            var dict = obj as System.Collections.Generic.IDictionary<string, object>;
            Width = System.Convert.ToInt32(dict["width"]);
            Height = System.Convert.ToInt32(dict["height"]);
        }

        public override string ToString()
        {
            return $"Normal {{ Width: {Width} Height: {Height} }}";
        }
    }

    [ScriptableType]
    public class ShortcutDetails
    {
        [ScriptableMember(ScriptAlias = "appUserModelId")]
        public string AppUserModelId { get; set; }
        [ScriptableMember(ScriptAlias = "args")]
        public string Args { get; set; }
        [ScriptableMember(ScriptAlias = "cwd")]
        public string Cwd { get; set; }
        [ScriptableMember(ScriptAlias = "description")]
        public string Description { get; set; }
        [ScriptableMember(ScriptAlias = "icon")]
        public string Icon { get; set; }
        [ScriptableMember(ScriptAlias = "iconIndex")]
        public int? IconIndex { get; set; }
        [ScriptableMember(ScriptAlias = "target")]
        public string Target { get; set; }
    }

    [ScriptableType]
    public struct RemoveClientCertificate
    {
        [ScriptableMember(ScriptAlias = "origin")]
        public string Origin { get; set; }
        [ScriptableMember(ScriptAlias = "type")]
        public string Type { get; set; }

    }


    [ScriptableType]
    public struct RemovePassword
    {
        [ScriptableMember(ScriptAlias = "origin")]
        public string Origin { get; set; }
        [ScriptableMember(ScriptAlias = "password")]
        public string Password { get; set; }
        [ScriptableMember(ScriptAlias = "realm")]
        public string Realm { get; set; }
        [ScriptableMember(ScriptAlias = "scheme", EnumValue = ConvertEnum.ToLower)]
        public AuthScheme Scheme { get; set; }
        [ScriptableMember(ScriptAlias = "type")]
        public string Type { get; set; }
        [ScriptableMember(ScriptAlias = "username")]
        public string Username { get; set; }

    }

    public enum AuthScheme
    {
        Basic,
        Digest,
        Ntlm,
        Negotiate
    }

    [ScriptableType]
    public class Certificate
    {
        [ScriptableMember(ScriptAlias = "data")]
        public string Data { get; set; }
        [ScriptableMember(ScriptAlias = "fingerprint")]
        public string Fingerprint { get; set; }
        [ScriptableMember(ScriptAlias = "issuer")]
        public CertificatePrincipal Issuer { get; set; }
        [ScriptableMember(ScriptAlias = "issuerCert")]
        public Certificate IssuerCert { get; set; }
        [ScriptableMember(ScriptAlias = "issuerName")]
        public string IssuerName { get; set; }
        [ScriptableMember(ScriptAlias = "serialNumber")]
        public string SerialNumber { get; set; }
        [ScriptableMember(ScriptAlias = "subject")]
        public CertificatePrincipal Subject { get; set; }
        [ScriptableMember(ScriptAlias = "subjectName")]
        public string SubjectName { get; set; }
        [ScriptableMember(ScriptAlias = "validExpiry")]
        public double ValidExpiry { get; set; }
        [ScriptableMember(ScriptAlias = "validStart")]
        public double ValidStart { get; set; }

    }

    [ScriptableType]
    public class CertificatePrincipal
    {
        [ScriptableMember(ScriptAlias = "commonName")]
        public string CommonName { get; set; }
        [ScriptableMember(ScriptAlias = "country")]
        public string Country { get; set; }
        [ScriptableMember(ScriptAlias = "locality")]
        public string Locality { get; set; }
        [ScriptableMember(ScriptAlias = "organizations")]
        public object[] Organizations { get; set; }
        [ScriptableMember(ScriptAlias = "organizationUnits")]
        public object[] OrganizationUnits { get; set; }
        [ScriptableMember(ScriptAlias = "state")]
        public string State { get; set; }

    }

    [ScriptableType]
    public class UploadData
    {
        [ScriptableMember(ScriptAlias = "blobUUID")]
        public string BlobUUID { get; set; }
        [ScriptableMember(ScriptAlias = "bytes")]
        public byte[] Bytes { get; set; }
        [ScriptableMember(ScriptAlias = "file")]
        public string File { get; set; }
    }

    [ScriptableType]
    public class CrashReport
    {
        [ScriptableMember(ScriptAlias = "date")]
        public string Date { get; private set; }
        [ScriptableMember(ScriptAlias = "ID")]
        public long ID { get; private set; }
    }

    [ScriptableType]
    public class Cookie
    {

        [ScriptableMember(ScriptAlias = "domain")]
        public string Domain { get; set; }
        [ScriptableMember(ScriptAlias = "expirationDate")]
        public double expirationDate { get; set; }
        [ScriptableMember(ScriptAlias = "hostOnly")]
        public bool? HostOnly { get; set; }
        [ScriptableMember(ScriptAlias = "httpOnly")]
        public bool? HttpOnly { get; set; }
        [ScriptableMember(ScriptAlias = "name")]
        public string Name { get; set; }
        [ScriptableMember(ScriptAlias = "path")]
        public string Path { get; set; }
        [ScriptableMember(ScriptAlias = "secure")]
        public bool? Secure { get; set; }
        [ScriptableMember(ScriptAlias = "session")]
        public bool? Session { get; set; }
        [ScriptableMember(ScriptAlias = "value")]
        public string Value { get; set; }
    }

}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
    
    
    #region Component Designer generated code 
    public partial class TextWriter_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.IO.@__TextWriter.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IO.TextWriter))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.TextWriter))]
    internal sealed partial class @__TextWriter : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__TextWriter(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.IO.@__TextWriter.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__TextWriter);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Dispose", "Dispose0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFormatProvider", "FormatProvider1", "()Lsystem/IFormatProvider;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Close", "Close2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Flush", "Flush3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEncoding", "Encoding4", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getNewLine", "NewLine5", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setNewLine", "NewLine6", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Synchronized", "Synchronized7", "(Lsystem/io/TextWriter;)Lsystem/io/TextWriter;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write8", "(C)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write9", "([C)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write10", "([CII)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write11", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write12", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write13", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write14", "(F)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write15", "(D)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write16", "(Lsystem/Decimal;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write17", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write18", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write19", "(Ljava/lang/String;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write20", "(Ljava/lang/String;Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write21", "(Ljava/lang/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Write", "Write22", "(Ljava/lang/String;[Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine23", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine24", "(C)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine25", "([C)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine26", "([CII)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine27", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine28", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine29", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine30", "(F)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine31", "(D)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine32", "(Lsystem/Decimal;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine33", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine34", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine35", "(Ljava/lang/String;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine36", "(Ljava/lang/String;Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine37", "(Ljava/lang/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "WriteLine", "WriteLine38", "(Ljava/lang/String;[Lsystem/Object;)V"));
            return methods;
        }
        
        private static void Dispose0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            ((global::System.IDisposable)(@__real)).Dispose();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::System.IntPtr FormatProvider1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/IFormatProvider;
            // ()LSystem/IFormatProvider;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.IFormatProvider>(@__env, @__real.FormatProvider);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Close2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Flush3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Flush();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::System.IntPtr Encoding4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Text/Encoding;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Text.Encoding>(@__env, @__real.Encoding);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr NewLine5(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.NewLine);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static void NewLine6(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.NewLine = global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::System.IntPtr Synchronized7(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr writer) {
            // (Lsystem/io/TextWriter;)Lsystem/io/TextWriter;
            // (LSystem/IO/TextWriter;)LSystem/IO/TextWriter;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.IO.TextWriter>(@__env, global::System.IO.TextWriter.Synchronized(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, writer)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Write8(global::System.IntPtr @__envp, global::System.IntPtr @__obj, char value) {
            // (C)V
            // (C)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write9(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr buffer) {
            // ([C)V
            // ([C)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write10(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr buffer, int index, int count) {
            // ([CII)V
            // ([CII)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer), index, count);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write11(global::System.IntPtr @__envp, global::System.IntPtr @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write12(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write13(global::System.IntPtr @__envp, global::System.IntPtr @__obj, long value) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write14(global::System.IntPtr @__envp, global::System.IntPtr @__obj, float value) {
            // (F)V
            // (F)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write15(global::System.IntPtr @__envp, global::System.IntPtr @__obj, double value) {
            // (D)V
            // (D)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write16(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Decimal;)V
            // (LSystem/Decimal;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJp2C<decimal>(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write17(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write18(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write19(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0) {
            // (Ljava/lang/String;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write20(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1) {
            // (Ljava/lang/String;Lsystem/Object;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write21(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2) {
            // (Ljava/lang/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg1), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Write22(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg) {
            // (Ljava/lang/String;[Lsystem/Object;)V
            // (LSystem/String;[LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.Write(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, arg));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine23(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine24(global::System.IntPtr @__envp, global::System.IntPtr @__obj, char value) {
            // (C)V
            // (C)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine25(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr buffer) {
            // ([C)V
            // ([C)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine26(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr buffer, int index, int count) {
            // ([CII)V
            // ([CII)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer), index, count);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine27(global::System.IntPtr @__envp, global::System.IntPtr @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine28(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine29(global::System.IntPtr @__envp, global::System.IntPtr @__obj, long value) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine30(global::System.IntPtr @__envp, global::System.IntPtr @__obj, float value) {
            // (F)V
            // (F)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine31(global::System.IntPtr @__envp, global::System.IntPtr @__obj, double value) {
            // (D)V
            // (D)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine32(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Decimal;)V
            // (LSystem/Decimal;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJp2C<decimal>(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine33(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine34(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine35(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0) {
            // (Ljava/lang/String;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine36(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1) {
            // (Ljava/lang/String;Lsystem/Object;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine37(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg0, global::System.IntPtr arg1, global::System.IntPtr arg2) {
            // (Ljava/lang/String;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V
            // (LSystem/String;LSystem/Object;LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg1), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, arg2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void WriteLine38(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr format, global::System.IntPtr arg) {
            // (Ljava/lang/String;[Lsystem/Object;)V
            // (LSystem/String;[LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextWriter @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextWriter>(@__env, @__obj);
            @__real.WriteLine(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, format), global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, arg));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.IO.@__TextWriter(@__env);
            }
        }
    }
    #endregion
}

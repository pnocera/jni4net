//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class OutputStream : global::java.lang.Object, global::java.io.Closeable, global::java.io.Flushable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _close0;
        
        internal static global::net.sf.jni4net.jni.MethodId _flush1;
        
        internal static global::net.sf.jni4net.jni.MethodId _write2;
        
        internal static global::net.sf.jni4net.jni.MethodId _write3;
        
        internal static global::net.sf.jni4net.jni.MethodId _write4;
        
        protected OutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.OutputStream.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.OutputStream.staticClass = @__class;
            global::java.io.OutputStream._close0 = @__env.GetMethodID(global::java.io.OutputStream.staticClass, "close", "()V");
            global::java.io.OutputStream._flush1 = @__env.GetMethodID(global::java.io.OutputStream.staticClass, "flush", "()V");
            global::java.io.OutputStream._write2 = @__env.GetMethodID(global::java.io.OutputStream.staticClass, "write", "([B)V");
            global::java.io.OutputStream._write3 = @__env.GetMethodID(global::java.io.OutputStream.staticClass, "write", "([BII)V");
            global::java.io.OutputStream._write4 = @__env.GetMethodID(global::java.io.OutputStream.staticClass, "write", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.io.OutputStream._close0);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void flush() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::java.io.OutputStream._flush1);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)V")]
        public virtual void write(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.io.OutputStream._write2, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)V")]
        public virtual void write(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallVoidMethod(this, global::java.io.OutputStream._write3, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void write(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.io.OutputStream._write4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.OutputStream(@__env);
            }
        }
    }
    #endregion
}

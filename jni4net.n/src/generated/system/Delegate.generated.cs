//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class Delegate_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__Delegate.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Delegate), typeof(global::System.Delegate_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Delegate), typeof(global::System.Delegate_))]
    internal sealed partial class @__Delegate : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Delegate(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__Delegate.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Delegate);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Clone", "Clone0", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetObjectData", "GetObjectData1", "(Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/St" +
                        "reamingContext;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "DynamicInvoke", "DynamicInvoke2", "([Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Combine", "Combine3", "(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Combine", "Combine4", "([Lsystem/Delegate;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetInvocationList", "GetInvocationList5", "()[Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMethod", "Method6", "()Lsystem/reflection/MethodInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTarget", "Target7", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Remove", "Remove8", "(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RemoveAll", "RemoveAll9", "(Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate10", "(Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate11", "(Lsystem/Type;Lsystem/Object;Ljava/lang/String;Z)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate12", "(Lsystem/Type;Lsystem/Object;Ljava/lang/String;ZZ)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate13", "(Lsystem/Type;Lsystem/Type;Ljava/lang/String;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate14", "(Lsystem/Type;Lsystem/Type;Ljava/lang/String;Z)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate15", "(Lsystem/Type;Lsystem/Type;Ljava/lang/String;ZZ)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate16", "(Lsystem/Type;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate17", "(Lsystem/Type;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate18", "(Lsystem/Type;Lsystem/Object;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateDelegate", "CreateDelegate19", "(Lsystem/Type;Lsystem/Object;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Clone0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.ICloneable)(@__real)).Clone());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void GetObjectData1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle info, global::net.sf.jni4net.utils.JniLocalHandle context) {
            // (Lsystem/runtime/serialization/SerializationInfo;Lsystem/runtime/serialization/StreamingContext;)V
            // (LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            ((global::System.Runtime.Serialization.ISerializable)(@__real)).GetObjectData(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Runtime.Serialization.SerializationInfo>(@__env, info), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Runtime.Serialization.StreamingContext>(@__env, context));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle DynamicInvoke2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle args) {
            // ([Lsystem/Object;)Lsystem/Object;
            // ([LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.DynamicInvoke(global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, args)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Combine3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle a, global::net.sf.jni4net.utils.JniLocalHandle b) {
            // (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;
            // (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.Combine(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, a), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, b)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Combine4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle delegates) {
            // ([Lsystem/Delegate;)Lsystem/Delegate;
            // ([LSystem/Delegate;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.Combine(global::net.sf.jni4net.utils.Convertor.ArrayStrongJp2C<System.Delegate[], global::System.Delegate>(@__env, delegates)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetInvocationList5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lsystem/Delegate;
            // ()[LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Delegate[], global::System.Delegate>(@__env, @__real.GetInvocationList());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Method6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/reflection/MethodInfo;
            // ()LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodInfo>(@__env, @__real.Method);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Target7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Delegate @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.Target);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Remove8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle source, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;
            // (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.Remove(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, source), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, value)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RemoveAll9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle source, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Delegate;Lsystem/Delegate;)Lsystem/Delegate;
            // (LSystem/Delegate;LSystem/Delegate;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.RemoveAll(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, source), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Delegate>(@__env, value)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method) {
            // (Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Object;LSystem/String;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method, bool ignoreCase) {
            // (Lsystem/Type;Lsystem/Object;Ljava/lang/String;Z)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Object;LSystem/String;Z)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method), ignoreCase));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method, bool ignoreCase, bool throwOnBindFailure) {
            // (Lsystem/Type;Lsystem/Object;Ljava/lang/String;ZZ)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Object;LSystem/String;ZZ)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method), ignoreCase, throwOnBindFailure));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method) {
            // (Lsystem/Type;Lsystem/Type;Ljava/lang/String;)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Type;LSystem/String;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method, bool ignoreCase) {
            // (Lsystem/Type;Lsystem/Type;Ljava/lang/String;Z)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Type;LSystem/String;Z)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method), ignoreCase));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle target, global::net.sf.jni4net.utils.JniLocalHandle method, bool ignoreCase, bool throwOnBindFailure) {
            // (Lsystem/Type;Lsystem/Type;Ljava/lang/String;ZZ)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Type;LSystem/String;ZZ)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, target), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, method), ignoreCase, throwOnBindFailure));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle method) {
            // (Lsystem/Type;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Reflection/MethodInfo;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodInfo>(@__env, method)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle method, bool throwOnBindFailure) {
            // (Lsystem/Type;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodInfo>(@__env, method), throwOnBindFailure));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle firstArgument, global::net.sf.jni4net.utils.JniLocalHandle method) {
            // (Lsystem/Type;Lsystem/Object;Lsystem/reflection/MethodInfo;)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Object;LSystem/Reflection/MethodInfo;)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, firstArgument), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodInfo>(@__env, method)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateDelegate19(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle type, global::net.sf.jni4net.utils.JniLocalHandle firstArgument, global::net.sf.jni4net.utils.JniLocalHandle method, bool throwOnBindFailure) {
            // (Lsystem/Type;Lsystem/Object;Lsystem/reflection/MethodInfo;Z)Lsystem/Delegate;
            // (LSystem/Type;LSystem/Object;LSystem/Reflection/MethodInfo;Z)LSystem/Delegate;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Delegate>(@__env, global::System.Delegate.CreateDelegate(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, type), global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, firstArgument), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodInfo>(@__env, method), throwOnBindFailure));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__Delegate(@__env);
            }
        }
    }
    #endregion
}

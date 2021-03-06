﻿#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/
It's derived work on top of OpenJDK 
*/

#endregion
#region Copyright 2000-2008 Sun Microsystems, Inc.  All Rights Reserved.
/*
 * Copyright 2000-2008 Sun Microsystems, Inc.  All Rights Reserved.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * This code is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License version 2 only, as
 * published by the Free Software Foundation.  Sun designates this
 * particular file as subject to the "Classpath" exception as provided
 * by Sun in the LICENSE file that accompanied this code.
 *
 * This code is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
 * version 2 for more details (a copy is included in the LICENSE file that
 * accompanied this code).
 *
 * You should have received a copy of the GNU General Public License version
 * 2 along with this work; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 * Please contact Sun Microsystems, Inc., 4150 Network Circle, Santa Clara,
 * CA 95054 USA or visit www.sun.com if you need additional information or
 * have any questions.
 */

#endregion

using System;
using java.lang;
using java.nio;

namespace net.sf.jni4net.nio
{
    /**
     * A read/write HeapByteBuffer.
     */
    internal class HeapByteBufferN : ByteBufferN
    {
        internal HeapByteBufferN(int cap, int lim)
            : base(-1, 0, lim, cap, new byte[cap], 0)
        {
        }

        internal HeapByteBufferN(byte[] buf, int off, int len)
            : base(-1, off, off + len, buf.Length, buf, 0)
        {
        }

        protected HeapByteBufferN(byte[] buf,
                                 int mark, int pos, int lim, int cap,
                                 int off)
            : base(mark, pos, lim, cap, buf, off)
        {
        }

        public override ByteBufferN slice()
        {
            return new HeapByteBufferN(hb,
                                      -1,
                                      0,
                                      remaining(),
                                      remaining(),
                                      position() + _offset);
        }

        public override ByteBufferN duplicate()
        {
            return new HeapByteBufferN(hb,
                                      markValue(),
                                      position(),
                                      limit(),
                                      capacity(),
                                      _offset);
        }

        public override ByteBufferN asReadOnlyBuffer()
        {
            /*return new HeapByteBufferR(hb,
				     this.markValue(),
				     this.position(),
				     this.limit(),
				     this.capacity(),
                     _offset);*/


            throw new NotImplementedException();
        }


        protected int ix(int i)
        {
            return i + _offset;
        }

        public override byte get()
        {
            return hb[ix(nextGetIndex())];
        }

        public override byte get(int i)
        {
            return hb[ix(checkIndex(i))];
        }

        public override ByteBufferN get(byte[] dst, int offset, int length)
        {
            checkBounds(offset, length, dst.Length);
            if (length > remaining())
                throw new BufferUnderflowException();
            Array.Copy(hb, ix(position()), dst, offset, length);
            position(position() + length);
            return this;
        }

        public override bool isDirect()
        {
            return false;
        }


        public override bool isReadOnly()
        {
            return false;
        }

        public override ByteBufferN put(byte x)
        {
            hb[ix(nextPutIndex())] = x;
            return this;
        }

        public override ByteBufferN put(int i, byte x)
        {
            hb[ix(checkIndex(i))] = x;
            return this;
        }

        public override ByteBufferN put(byte[] src, int offset, int length)
        {
            checkBounds(offset, length, src.Length);
            if (length > remaining())
                throw new BufferOverflowException();
            Array.Copy(src, offset, hb, ix(position()), length);
            position(position() + length);
            return this;
        }

        public override ByteBufferN put(ByteBufferN src)
        {
            if (src is HeapByteBufferN)
            {
                if (src == this)
                    throw new IllegalArgumentException();
                var sb = (HeapByteBufferN) src;
                int n = sb.remaining();
                if (n > remaining())
                    throw new BufferOverflowException();
                Array.Copy(sb.hb, sb.ix(sb.position()),
                           hb, ix(position()), n);
                sb.position(sb.position() + n);
                position(position() + n);
            }
            else if (src.isDirect())
            {
                int n = src.remaining();
                if (n > remaining())
                    throw new BufferOverflowException();
                src.get(hb, ix(position()), n);
                position(position() + n);
            }
            else
            {
                base.put(src);
            }
            return this;
        }

        public override ByteBufferN compact()
        {
            Array.Copy(hb, ix(position()), hb, ix(0), remaining());
            position(remaining());
            limit(capacity());
            discardMark();
            return this;
        }


        internal override byte _get(int i)
        {
            return hb[i];
        }

        internal override void _put(int i, byte b)
        {
            hb[i] = b;
        }

        // char


        public override char getChar()
        {
            return BitConverter.ToChar(hb, ix(nextGetIndex(2)));
        }

        public override char getChar(int i)
        {
            return BitConverter.ToChar(hb, ix(checkIndex(i, 2)));
        }


        public override ByteBufferN putChar(char x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(2));
            Array.Copy(bytes, 0, hb, index, 2);
            return this;
        }

        public override ByteBufferN putChar(int i, char x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 2));
            Array.Copy(bytes, 0, hb, index, 2);
            return this;
        }

        public override BufferN asCharBuffer()
        {
            /*int size = this.remaining() >> 1;
	int off = offset + position();
	return (bigEndian
		? (CharBuffer)(new ByteBufferAsCharBufferB(this,
							       -1,
							       0,
							       size,
							       size,
							       off))
		: (CharBuffer)(new ByteBufferAsCharBufferL(this,
							       -1,
							       0,
							       size,
							       size,
							       off)));
     */
            throw new NotImplementedException();
        }


        // short


        public override short getShort()
        {
            return BitConverter.ToInt16(hb, ix(nextGetIndex(2)));
        }

        public override short getShort(int i)
        {
            return BitConverter.ToInt16(hb, ix(checkIndex(i, 2)));
        }


        public override ByteBufferN putShort(short x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(2));
            Array.Copy(bytes, 0, hb, index, 2);
            return this;
        }

        public override ByteBufferN putShort(int i, short x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 2));
            Array.Copy(bytes, 0, hb, index, 2);
            return this;
        }

        public override BufferN asShortBuffer()
        {
            /*int size = this.remaining() >> 1;
	int off = offset + position();
	return (bigEndian
		? (ShortBuffer)(new ByteBufferAsShortBufferB(this,
								 -1,
								 0,
								 size,
								 size,
								 off))
		: (ShortBuffer)(new ByteBufferAsShortBufferL(this,
								 -1,
								 0,
								 size,
								 size,
								 off)));*/
            throw new NotImplementedException();
        }


        // int


        public override int getInt()
        {
            return BitConverter.ToInt32(hb, ix(nextGetIndex(4)));
        }

        public override int getInt(int i)
        {
            return BitConverter.ToInt32(hb, ix(checkIndex(i, 4)));
        }


        public override ByteBufferN putInt(int x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(4));
            Array.Copy(bytes, 0, hb, index, 4);
            return this;
        }

        public override ByteBufferN putInt(int i, int x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 4));
            Array.Copy(bytes, 0, hb, index, 4);
            return this;
        }

        public override BufferN asIntBuffer()
        {
            /*int size = this.remaining() >> 2;
	int off = offset + position();
	return (bigEndian
		? (IntBuffer)(new ByteBufferAsIntBufferB(this,
							     -1,
							     0,
							     size,
							     size,
							     off))
		: (IntBuffer)(new ByteBufferAsIntBufferL(this,
							     -1,
							     0,
							     size,
							     size,
							     off)));*/
            throw new NotImplementedException();
        }


        // long


        public override long getLong()
        {
            return BitConverter.ToInt64(hb, ix(nextGetIndex(8)));
        }

        public override long getLong(int i)
        {
            return BitConverter.ToInt64(hb, ix(checkIndex(i, 8)));
        }


        public override ByteBufferN putLong(long x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(8));
            Array.Copy(bytes, 0, hb, index, 8);
            return this;
        }

        public override ByteBufferN putLong(int i, long x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 8));
            Array.Copy(bytes, 0, hb, index, 8);
            return this;
        }

        public override BufferN asLongBuffer()
        {
            /*int size = this.remaining() >> 3;
	int off = offset + position();
	return (bigEndian
		? (LongBuffer)(new ByteBufferAsLongBufferB(this,
							       -1,
							       0,
							       size,
							       size,
							       off))
		: (LongBuffer)(new ByteBufferAsLongBufferL(this,
							       -1,
							       0,
							       size,
							       size,
							       off)));*/
            throw new NotImplementedException();
        }


        // float


        public override float getFloat()
        {
            return BitConverter.ToSingle(hb, ix(nextGetIndex(4)));
        }

        public override float getFloat(int i)
        {
            return BitConverter.ToSingle(hb, ix(checkIndex(i, 4)));
        }


        public override ByteBufferN putFloat(float x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(4));
            Array.Copy(bytes, 0, hb, index, 4);
            return this;
        }

        public override ByteBufferN putFloat(int i, float x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 4));
            Array.Copy(bytes, 0, hb, index, 4);
            return this;
        }

        public override BufferN asFloatBuffer()
        {
            /*int size = this.remaining() >> 2;
	int off = offset + position();
	return (bigEndian
		? (FloatBuffer)(new ByteBufferAsFloatBufferB(this,
								 -1,
								 0,
								 size,
								 size,
								 off))
		: (FloatBuffer)(new ByteBufferAsFloatBufferL(this,
								 -1,
								 0,
								 size,
								 size,
								 off)));*/
            throw new NotImplementedException();
        }


        // double


        public override double getDouble()
        {
            return BitConverter.ToDouble(hb, ix(nextGetIndex(8)));
        }

        public override double getDouble(int i)
        {
            return BitConverter.ToDouble(hb, ix(checkIndex(i, 8)));
        }


        public override ByteBufferN putDouble(double x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(nextPutIndex(8));
            Array.Copy(bytes, 0, hb, index, 8);
            return this;
        }

        public override ByteBufferN putDouble(int i, double x)
        {
            byte[] bytes = BitConverter.GetBytes(x);
            int index = ix(checkIndex(i, 8));
            Array.Copy(bytes, 0, hb, index, 8);
            return this;
        }

        public override BufferN asDoubleBuffer()
        {
            /*int size = this.remaining() >> 3;
	int off = offset + position();
	return (bigEndian
		? (DoubleBuffer)(new ByteBufferAsDoubleBufferB(this,
								   -1,
								   0,
								   size,
								   size,
								   off))
		: (DoubleBuffer)(new ByteBufferAsDoubleBufferL(this,
								   -1,
								   0,
								   size,
								   size,
								   off)));*/
            throw new NotImplementedException();
        }
    }
}

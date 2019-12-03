/*
 * This file is part of the TableStream package.
 *
 * (c) MuGuangyi <muguangyi@hotmail.com>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.IO;

namespace DictStream
{
    abstract class StringStream : IDisposable
    {
        protected const byte TINDEX = 0x00;
        protected const byte STRING = 0x01;

        protected readonly Stream stream = null;

        public StringStream(Stream stream)
        {
            this.stream = stream;
        }

        public virtual void Dispose()
        {
            if (this.stream != null)
            {
                this.stream.Close();
            }
        }
    }
}
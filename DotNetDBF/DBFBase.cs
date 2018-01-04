/*
 Serves as the base class of DBFReader adn DBFWriter.
 
 This file is part of DotNetDBF packege.
 
 original author (javadbf): anil@linuxense.com 2004/03/31
 license: LGPL (http://www.gnu.org/copyleft/lesser.html)

 Support for choosing implemented character Sets as
 suggested by Nick Voznesensky <darkers@mail.ru>
 
 ported to C# (DotNetDBF): Jay Tuley <jay+dotnetdbf@tuley.name> 6/28/2007
 
 */
/**
 Base class for DBFReader and DBFWriter.
 */

using System;
using System.Text;

namespace DotNetDBF
{
    public abstract class DBFBase
    {
        protected Encoding _charEncoding = Encoding.GetEncoding("utf-8");
        protected int _blockSize = 512;
        private string _nullSymbol;

        public Encoding CharEncoding
        {
            set { _charEncoding = value; }

            get { return _charEncoding; }
        }

        public int BlockSize
        {
            set { _blockSize = value; }

            get { return _blockSize; }
        }
        
        public string NullSymbol
        {
            get { return _nullSymbol ?? DBFFieldType.Unknown; }
            set
            {
                if (value != null && value.Length != 1)
                    throw new ArgumentException(nameof(NullSymbol));
                _nullSymbol = value;
            }
        }
	
    }
}
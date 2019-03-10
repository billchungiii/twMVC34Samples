using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamSample001
{
    /// <summary>
    /// VS2019 preview 2 後必須搭配新的.NET Core SDK v3.0.100.010177 以上
    /// 本次用的版本是  .NET Core SDK 3.0.100.010272
    /// 微軟修改了  IAsyncEnumerable interface 的內容
    /// </summary>
    sealed class AsyncFileProcess : IAsyncEnumerable<string>, IAsyncEnumerator<string>
    {
        private readonly StreamReader _reader;

        private bool _disposed;
        public AsyncFileProcess(string path)
        {
            _reader = File.OpenText(path);
            _disposed = false;
        }

        public string Current { get; private set; }
     
        async public ValueTask<bool> MoveNextAsync()
        {
            // 特別加上 Task.Daelay 展示效果
            await Task.Delay(100);
            Current = await _reader.ReadLineAsync();
            return Current != null;
        }

        async public ValueTask DisposeAsync()
        {
            await Task.Run(() => Dispose());
        }

        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_reader != null)
                {
                    _reader.Dispose();
                }
                _disposed = true;
            }
        }

        public IAsyncEnumerator<string> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return this;
        }
    }
}

# Argon2CalibratorTool

This tool is used to calibrate parameters for the Argon2 algorithm. Initial credits go to https://github.com/bburman/Twelve21.PasswordStorage.

## Usage

You can find pre compiled binaries for the following platforms:

- Linux (x64)
- macOS (x64)
- Windows (x64)

Releases can be downloaded from [GitHub releases](https://github.com/proohit/Argon2CalibratorTool/releases)

After downloading the binaries, you might have to `chmod +x` the binaries.

```sh
chmod +x argon2-calibrator-linux-x64
chmod +x argon2-calibrator-macos-x64
```

Run the binaries with the following command:

```sh
./argon2-calibrator-linux-x64 --help

Usage:  [options]

Options:
  -?|-h|--help      Show help information
  -t|--time         The maximum time in milliseconds it should take to calculate the password hash. Defaults to 1000.
  -p|--parallelism  The degree of parallelism. Defaults to twice the number of CPU cores.
  -i|--iterations   The minimum number of iterations. Defaults to 2.
  -m|--mode         The mode of operation. The default is Argon2id. Advanced usage only.
  --saltlength      The length of the salt and password, in bytes. Defaults to 16. Advanced usage only.
  --hashlength      The length of the hash, in bytes. Defaults to 16. Advanced usage only.
```

The application will run and show you the best results, similar to:

```log
Best results:
M =  256 MB, T =    2, d = 8, Time = 0.732 s
M =  128 MB, T =    6, d = 8, Time = 0.99 s
M =   64 MB, T =   12, d = 8, Time = 0.968 s
M =   32 MB, T =   24, d = 8, Time = 0.896 s
M =   16 MB, T =   49, d = 8, Time = 0.973 s
M =    8 MB, T =   96, d = 8, Time = 0.991 s
M =    4 MB, T =  190, d = 8, Time = 0.977 s
M =    2 MB, T =  271, d = 8, Time = 0.973 s
M =    1 MB, T =  639, d = 8, Time = 0.991 s
```

## Development

**Requires .NET 6.0 or higher**

First, clone the git repository.

```sh
git clone https://github.com/proohit/Argon2CalibratorTool.git
```

Secondly, enter the directory and build the solution.

```sh
dotnet build
```

Next, enter the Argon2CalibratorTool subdirectory and run the Argon2 Calibration function.

```sh
cd ./Argon2CalibratorTool
dotnet run --
```

## Build and publish

```sh
dotnet publish -r [win-x64|linux-x64|osx-x64] -c Release --self-contained true
```

## License

[MIT License](https://opensource.org/licenses/MIT)

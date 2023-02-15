// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

const webpack = require("webpack");
const path = require("path");

const sharedCfg = (env) => {
  return {
    entry: "./src/App.fs.js",

    output: {
      path: path.join(__dirname, "./public"),
      filename: "bundle.js",
    },

    module: {
      rules: [
        {
          test: /\.html$/,
          loader: "html-loader",
        },

        {
          test: /\.(svg|png|jpe?g|gif)$/,
          loader: "file-loader",
          options: {
            name: "[name].[ext]",
          },
        },
      ],
    },
  };
};

const devCfg = (env) => {
  const shared = sharedCfg(env);

  return {
    ...shared,

    mode: "development",

    devServer: {
      static: {
        directory: path.resolve(__dirname, "./public"),
        publicPath: "/",
      },
      port: 8080,
    },

    plugins: [new webpack.HotModuleReplacementPlugin()],
  };
};

prodCfg = (env) => {
  const shared = sharedCfg(env);

  return {
    ...shared,

    mode: "production",
  };
};

module.exports = (env, argv) => {
  return argv.mode === "development" ? devCfg(env) : prodCfg(env);
};

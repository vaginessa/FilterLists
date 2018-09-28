const path = require("path");
const webpack = require("webpack");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = () => {
    return [
        {
            stats: { modules: false },
            resolve: {
                extensions: [".js"]
            },
            module: {
                rules: [
                    { test: /\.(png|woff|woff2|eot|ttf|svg)(\?|$)/, use: "url-loader?limit=100000" },
                    {
                        test: /\.css(\?|$)/,
                        use: [
                            { loader: MiniCssExtractPlugin.loader },
                            {
                                loader: "css-loader?minimize",
                                options: {
                                    sourceMap: true,
                                    modules: true,
                                    localIdentName: "[local]___[hash:base64:5]"
                                }
                            }
                        ]
                    }
                ]
            },
            entry: {
                vendor: [
                    "bootstrap", "bootstrap/dist/css/bootstrap.css", "event-source-polyfill", "isomorphic-fetch",
                    "react", "react-dom", "react-router-dom", "jquery"
                ]
            },
            output: {
                path: path.join(__dirname, "wwwroot", "dist"),
                publicPath: "dist/",
                filename: "[name].js",
                library: "[name]_[hash]"
            },
            plugins: [
                new MiniCssExtractPlugin({ filename: "vendor.css" }),
                new webpack.ProvidePlugin({
                    $: "jquery",
                    jQuery: "jquery"
                }),
                new webpack.DllPlugin({
                    path: path.join(__dirname, "wwwroot", "dist", "[name]-manifest.json"),
                    name: "[name]_[hash]"
                }),
                new webpack.DefinePlugin({
                    'process.env.NODE_ENV': '"production"'
                })
            ]
        }
    ];
};
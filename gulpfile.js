var {src, dest, watch} = require('gulp');
var sass = require('gulp-sass')(require('sass'));
var autoprefixer = require('gulp-autoprefixer');
var plumber = require('gulp-plumber');
var browserSync = require('browser-sync').create();

function bs() {
    serveSass();
    browserSync.init({
        server: {
            baseDir: "src"
        }
    });
    watch("./src/sass/**/*.sass").on("change", serveSass);
    watch("./src/*.html").on("change", browserSync.reload);
    watch("./js/*.js").on("change", browserSync.reload);
};

function onError(err){
    console.log(err);
}

function serveSass() {
    return src("./src/sass/**/*.sass")
        .pipe(sass())
        .pipe(autoprefixer({
            overrideBrowserslist: ['last 3 versions'],
            cascade: false
        }))
        .pipe(dest("./src/css"))
        .pipe(plumber({
            errorHandler: onError
        }))
        .pipe(browserSync.stream());
};

exports.serve = bs;
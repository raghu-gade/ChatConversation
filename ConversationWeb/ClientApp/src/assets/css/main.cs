@charset "UTF-8";
@import '../scss/vendors/bootstrap-4.5.0-dist/css/bootstrap.min.css';
.add-sales-overview, .vm-panel-box, .vm-add-panel, .vm-border-box {
  border: 0.1rem solid #e2ebfb;
  border-radius: 0.5rem;
}

@font-face {
  font-family: "SegoeUI";
  src: url("../fonts/segoe-ui/SegoeUI.eot");
  src: url("../fonts/segoe-ui/SegoeUI.eot?#iefix") format("embedded-opentype"), url("../fonts/segoe-ui/SegoeUI.woff") format("woff"), url("../fonts/segoe-ui/SegoeUI.ttf") format("truetype"), url("../fonts/segoe-ui/SegoeUI.svg#SegoeUI") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
@font-face {
  font-family: "SegoeUIBold";
  src: url("../fonts/segoe-ui/Segoe UI Bold.eot");
  src: url("../fonts/segoe-ui/Segoe UI Bold.eot?#iefix") format("embedded-opentype"), url("../fonts/segoe-ui/Segoe UI Bold.woff") format("woff"), url("../fonts/segoe-ui/Segoe UI Bold.ttf") format("truetype"), url("../fonts/segoe-ui/Segoe UI Bold.svg#SegoeUIBold") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
@font-face {
  font-family: "SegoeUISemibold";
  src: url("../fonts/segoe-ui/SegoeUI-Semibold.eot");
  src: url("../fonts/segoe-ui/SegoeUI-Semibold.eot?#iefix") format("embedded-opentype"), url("../fonts/segoe-ui/SegoeUI-Semibold.woff") format("woff"), url("../fonts/segoe-ui/SegoeUI-Semibold.ttf") format("truetype"), url("../fonts/segoe-ui/SegoeUI-Semibold.svg#SegoeUISemibold") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
@font-face {
  font-family: "Lato";
  src: url("../fonts/lato/Lato-Regular.eot");
  src: url("../fonts/lato/Lato-Regular.eot?#iefix") format("embedded-opentype"), url("../fonts/lato/Lato-Regular.woff") format("woff"), url("../fonts/lato/Lato-Regular.ttf") format("truetype"), url("../fonts/lato/Lato-Regular.svg#Lato") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
@font-face {
  font-family: "LatoBold";
  src: url("../fonts/lato/Lato-Bold.eot");
  src: url("../fonts/lato/Lato-Bold.eot?#iefix") format("embedded-opentype"), url("../fonts/lato/Lato-Bold.woff") format("woff"), url("../fonts/lato/Lato-Bold.ttf") format("truetype"), url("../fonts/lato/Lato-Bold.svg#LatoBold") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
@font-face {
  font-family: "LatoBlack";
  src: url("../fonts/lato/Lato-Black.eot");
  src: url("../fonts/lato/Lato-Black.eot?#iefix") format("embedded-opentype"), url("../fonts/lato/Lato-Black.woff") format("woff"), url("../fonts/lato/Lato-Black.ttf") format("truetype"), url("../fonts/lato/Lato-Black.svg#LatoBlack") format("svg");
  font-weight: normal;
  font-style: normal;
  text-rendering: optimizeLegibility;
}
html {
  font-size: 62.5%;
  scroll-behavior: smooth;
}
html* {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

html,
body {
  min-height: 100%;
}

::selection {
  background-color: #2684fe;
  color: #ffffff;
}

*,
*:after,
*:before {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}

body {
  background: #f7f7fc;
  font-family: "SegoeUI";
  font-weight: 400;
  line-height: 1.4;
  color: #323a4d;
  box-sizing: border-box;
  font-size: 1.4rem;
}

ul {
  margin: 0;
  padding: 0;
}
ul li {
  list-style: none;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  margin: 0;
  padding: 0;
}

img {
  border: none;
}

a:not([href]):not([tabindex]) {
  color: #2261db;
  text-decoration: none;
}
a:not([href]):not([tabindex]):hover {
  cursor: pointer !important;
  outline: none !important;
  color: #3670e0;
}

a:link, a:visited {
  text-decoration: none;
  cursor: pointer !important;
  outline: none;
  transition: all ease 0.3s;
  color: #2261db;
}
a:focus, a:hover {
  cursor: pointer !important;
  outline: none !important;
  color: #3670e0;
}

.vm-header-shadow {
  box-shadow: 0px 2px 1px 0px rgba(0, 63, 179, 0.12), 0px 0px 0px 1px rgba(0, 63, 179, 0.04);
}

.vm-d-none {
  display: none;
}

.vm-bg-primary {
  background-color: #2684fe;
}
.vm-bg-secondary {
  background-color: #62cf5d;
}
.vm-bg-teritary {
  background-color: #e5eeff;
}
.vm-bg-success {
  background-color: #62cf5d;
}
.vm-bg-danger {
  background-color: #ff455f;
}
.vm-bg-warning {
  background-color: #fff494;
}

.vm-text-primary {
  color: #2684fe;
}
.vm-text-secondary {
  color: #62cf5d;
}
.vm-text-teritary {
  color: #e5eeff;
}
.vm-text-black {
  color: #282842;
}
.vm-text-dark {
  color: #6d6d8c !important;
}
.vm-text-dark-extra {
  color: #7797d3;
}
.vm-text-light {
  color: #7797d3 !important;
}
.vm-text-light-extra {
  color: #3860ac;
}
.vm-text-light-light {
  color: #56568e;
}
.vm-text-warning {
  color: #99916d;
}

.vm-pl-0 {
  padding-left: 0 !important;
}

.vm-mt-60 {
  margin-top: 6rem;
}

.vm-border-content {
  border: 1px solid #e2ebfb;
}
.vm-border-top {
  border-top: 0.01rem solid #e2ebfb;
}
.vm-border-bottom {
  border-bottom: 0.01rem solid #e2ebfb;
}
.vm-border-bottom-shadow {
  border-bottom: 1px solid #177bfe;
  -webkit-box-shadow: 0px 1px 0 #3a90fe;
  -moz-box-shadow: 0px 1px 0 #3a90fe;
  -ms-box-shadow: 0px 1px 0 #3a90fe;
  -o-box-shadow: 0px 1px 0 #3a90fe;
  box-shadow: 0px 1px 0 #3a90fe;
}
.vm-border-bottom-dashed {
  border-bottom: 0.01rem dashed #e2ebfb;
}
.vm-border-bottom-lightBtm {
  border-bottom: 0.01rem dashed #fde710;
}
.vm-border-bottom-dark {
  border-bottom: 0.01rem solid #c7d8f7;
}
.vm-border-right-shadow {
  border-right: 1px solid #177bfe;
  -webkit-box-shadow: 1px 0px 0 #3a90fe;
  -moz-box-shadow: 1px 0px 0 #3a90fe;
  -ms-box-shadow: 1px 0px 0 #3a90fe;
  -o-box-shadow: 1px 0px 0 #3a90fe;
  box-shadow: 1px 0px 0 #3a90fe;
}
.vm-border-left-shadow {
  border-left: 1px solid #177bfe;
  -webkit-box-shadow: -1px 0px 0 #3a90fe;
  -moz-box-shadow: -1px 0px 0 #3a90fe;
  -ms-box-shadow: -1px 0px 0 #3a90fe;
  -o-box-shadow: -1px 0px 0 #3a90fe;
  box-shadow: -1px 0px 0 #3a90fe;
}

.vm-width-70 {
  width: 70px !important;
}
.vm-width-80 {
  width: 8rem !important;
}
.vm-width-90 {
  width: 9rem;
}
.vm-width-120 {
  width: 12rem;
}
.vm-width-150 {
  width: 15rem;
}
.vm-width-180 {
  width: 18rem;
}
.vm-width-200 {
  width: 20rem !important;
}
.vm-width-220 {
  width: 22rem !important;
}
.vm-width-250 {
  width: 25rem !important;
}
.vm-width-300 {
  width: 30rem !important;
}
.vm-width-auto {
  width: auto !important;
}

.vm-top5 {
  top: 0.5rem !important;
}

.vm-header-search-block {
  width: calc(100% - 6rem);
  height: 100%;
  position: fixed;
  background: #ffffff;
  top: 7.5rem;
  display: none;
  left: 7rem;
  z-index: 999;
  box-shadow: 0px -15px 10px 0px rgba(35, 96, 174, 0.07), 0px -5px 4px 0px rgba(35, 96, 174, 0.05);
}
.vm-header-search-block .vm-search-close {
  position: absolute;
  right: 0;
  top: -0.2rem;
  height: 6.3rem;
  width: 4rem;
  background: #ffffff;
  color: #ff455f;
  cursor: pointer;
  border-top-left-radius: 3rem;
  border-top-right-radius: 3rem;
  text-align: center;
  padding-top: 1rem;
  display: none;
  top: -6.3rem;
  right: 32rem;
}
.vm-header-search-block .vm-search-panel-right {
  width: calc(100% - 15px);
  height: 100%;
}
.vm-header-search-block .vm-header-lead {
  color: #81a8d6;
}
.vm-header-search-block .vm-header-customer {
  color: #62cf5d;
}
.vm-header-search-block .vm-search-grid:last-child {
  margin-bottom: 6rem;
}
.vm-header-search-block .vm-search-grid .vm-role label {
  padding-left: 2.4rem;
  cursor: pointer;
}
.vm-header-search-block .vm-search-grid .vm-name-icon {
  width: 2rem;
  height: 2rem;
  border-radius: 50%;
  text-align: center;
  display: inline-block;
  margin-right: 0.5rem;
  font-size: 1.1rem;
  line-height: 2rem;
  position: absolute;
  top: -1px;
}
.vm-header-search-block .vm-search-grid .vm-name-icon.lead {
  background: #81a8d6;
}
.vm-header-search-block .vm-search-grid .vm-name-icon.customer {
  background: #62cf5d;
}

.vm-bg-white {
  background-color: #ffffff !important;
}

.vm-bg-teritary-light {
  background-color: #eff5ff;
}

.vm-bg-teritary {
  background-color: #e5eeff;
}
.vm-bg-teritary-light {
  background-color: #f7faff;
}

.vm-bg-transparent {
  background-color: transparent !important;
}

.vm-text-danger {
  color: #ff455f !important;
}

.vm-text-color-secondary {
  color: #62cf5d !important;
}

.vm-main-p-control {
  width: 100%;
  padding: 3.5rem 2rem;
}

.vm-title-card {
  background-color: #ffffff;
box-shadow:0px 2px 2px rgba(171, 171, 184, 0.24), 0px 0px 5px rgba(171, 171, 184, 0.2) !important;  padding: 0rem 2rem;
  border-radius: 0.5rem;
  margin-bottom: 1.5rem;
  min-height: 70px;
  align-items: center;
  display: flex;
  justify-content: space-between;
}
.vm-title-card h2 {
  font-size: 2.2rem;
}

.vm-left-panel {
  padding-right: 0.5rem;
  display: flex;
}
.vm-left-panel .vm-left-card {
  background-color: #ffffff;
  border-radius: 5px;
  width: 100%;
  height: 100%;
}

.vm-right-panel {
  display: flex;
}

.vm-main-card {
  background-color: #ffffff;
  border-radius: 5px;
  width: 100%;
box-shadow:0px 2px 2px rgba(171, 171, 184, 0.24), 0px 0px 5px rgba(171, 171, 184, 0.2) !important;  position: relative;
}
.vm-main-card .vm-main-card-padding {
  padding: 3rem;
}
.vm-main-card .vm-main-card-padding-secondary {
  padding: 1.5rem;
}

.vm-heading-style {
  padding-bottom: 1rem;
  color: #282842;
}

.vm-profile-card-space {
  padding-left: 330px;
}

.vm-drop-panel {
  background-color: #f4f8ff;
  height: 380px;
  width: 100%;
  border: 0.2rem dashed #d1e1ff;
  border-radius: 0.5rem;
  display: flex;
  align-items: center;
  justify-content: center;
}

.mt-20 {
  margin-top: 2rem;
}

.mt-25 {
  margin-top: 2.5rem;
}

.vm-primary-radius {
  border-radius: 0.5rem;
}

.vm-pb-20 {
  padding-bottom: 2rem;
}

.vm-pb-30 {
  padding-bottom: 3rem;
}

.vm-pb-40 {
  padding-bottom: 4rem;
}

.vm-pb-50 {
  padding-bottom: 5rem;
}

.vm-pt-20 {
  padding-top: 2rem;
}

.vm-pt-30 {
  padding-top: 3rem;
}

.vm-pt-40 {
  padding-top: 4rem;
}

.vm-pt-50 {
  padding-top: 4rem;
}

.vm-p-25 {
  padding: 2.5rem;
}

.vm-pr-35 {
  padding-right: 3.5rem;
}

.vm-pl-35 {
  padding-left: 3.5rem;
}

.vm-py-20 {
  padding-top: 2rem;
  padding-bottom: 2rem;
}

.vm-p-20 {
  padding: 2rem;
}

.vm-link-color {
  color: #2261db;
}

.vm-height-90 {
  height: 90px !important;
}

.vm-height-60 {
  height: 60px !important;
}

.vm-border-top {
  border-top: 0.1rem solid #e2ebfb;
}

.vm-border-bottom {
  border-bottom: 0.1rem solid #e2ebfb;
}

.vm-border-left {
  border-left: 0.1rem solid #e2ebfb;
}

.vm-border-right {
  border-right: 0.1rem solid #e2ebfb;
}

.vm-border-top-none {
  border-top: none !important;
}

.vm-border-bottom-none {
  border-bottom: none !important;
}

.vm-heavy-label {
  font-size: 1.4rem;
  font-family: "SegoeUIBold";
  color: #282842 !important;
  margin-bottom: 0rem;
}

.vm-blue-tags {
  padding: 0.5rem 1.5rem;
  vertical-align: middle;
  background: #81a8d6;
  border-radius: 2rem;
  color: #ffffff;
  padding: 0.6rem 1.2rem;
  display: inline-flex;
  align-items: center;
}
.vm-blue-tags span {
  line-height: 1;
}
.vm-blue-tags .vm-tag-close {
  color: #284f7c;
  font-family: "SegoeUISemibold";
  font-size: 1.4rem;
  padding-left: 0.5rem;
  cursor: pointer;
}

.comma-separate-align {
  position: absolute;
  left: 100px;
  top: 5px;
}

.vm-internal-footer {
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
}

.vm-list-inside-panel ul li {
  padding: 1rem 1.5rem;
  border-bottom: 0.1rem solid #e2ebfb;
  display: flex;
  align-items: center;
}
.vm-list-inside-panel ul li.selected {
  background-color: #eff5ff;
}
.vm-list-inside-panel ul li.selected:after {
  background-image: url(../img/tick.svg);
  content: "";
  width: 24px;
  height: 20px;
  position: absolute;
  right: 2rem;
  background-repeat: no-repeat;
}
.vm-list-inside-panel ul li .icon-drag {
  margin-right: 0.5rem;
}
.vm-list-inside-panel ul li:last-child {
  margin-bottom: -1px;
}

.vm-img-upload {
  display: flex;
  align-items: center;
  justify-content: flex-end;
  position: relative;
  flex-direction: column;
}
.vm-img-upload .vm-img-remove {
  width: 30px;
  height: 30px;
  background-color: #ff455f;
  color: #ffffff;
  font-family: "SegoeUIBold";
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 9px;
  line-height: 9px;
  position: absolute;
  right: 10px;
  top: 6px;
  cursor: pointer;
  transition: box-shadow 0.4s ease-in;
  -webkit-box-shadow: 0px 10px 5px 0px rgba(242, 59, 85, 0.6);
  -moz-box-shadow: 0px 10px 5px 0px rgba(242, 59, 85, 0.6);
  -ms-box-shadow: 0px 10px 5px 0px rgba(242, 59, 85, 0.6);
  -o-box-shadow: 0px 10px 5px 0px rgba(242, 59, 85, 0.6);
  box-shadow: 0px 10px 5px 0px rgba(242, 59, 85, 0.6);
}
.vm-img-upload .vm-img-remove:hover {
  -webkit-box-shadow: 0px 15px 15px 0px rgba(242, 59, 85, 0.6);
  -moz-box-shadow: 0px 15px 15px 0px rgba(242, 59, 85, 0.6);
  -ms-box-shadow: 0px 15px 15px 0px rgba(242, 59, 85, 0.6);
  -o-box-shadow: 0px 15px 15px 0px rgba(242, 59, 85, 0.6);
  box-shadow: 0px 15px 15px 0px rgba(242, 59, 85, 0.6);
}
.vm-img-upload .vm-img-edit {
  width: 44px;
  height: 44px;
  border-radius: 50%;
  background-color: #ffffff;
  position: absolute;
  bottom: -5px;
  left: 10px;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: box-shadow 0.4s ease-in;
  cursor: pointer;
  -webkit-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
}
.vm-img-upload .vm-img-edit:hover {
  -webkit-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
}
.vm-img-upload img.vm-img {
  width: 13.5rem;
  height: 13.5rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}

.vm-add-panel {
  border: 0.2rem dashed #b8d0ff;
  background-color: #e5eeff;
  display: flex;
  align-items: center;
  flex-direction: column;
  justify-content: center;
}

.vm-add-panel-rounded {
  background-color: #e5eeff;
  border: 0.1px solid #e2ebfb;
  padding: 0.6rem;
  display: inline-flex;
  border-radius: 100%;
  position: absolute;
  left: 50%;
  bottom: 0;
  -webkit-transform: translateX(-50%) translateY(50%);
  -moz-transform: translateX(-50%) translateY(50%);
  -ms-transform: translateX(-50%) translateY(50%);
  -o-transform: translateX(-50%) translateY(50%);
  transform: translateX(-50%) translateY(50%);
  cursor: pointer;
  border-left: 0.1rem solid #eff5ff;
  border-top: 0.1rem solid #eff5ff;
}
.vm-add-panel-rounded svg {
  -webkit-transform: rotate(45deg);
  -moz-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  -o-transform: rotate(45deg);
  transform: rotate(45deg);
}

.vm-panel-box > header {
  padding: 0rem 2.5rem;
  border-bottom: 0.1rem solid #e2ebfb;
  height: 70px;
  display: flex;
  align-items: center;
}

.vm-prefix-input {
  position: relative;
  display: flex;
  align-items: center;
}
.vm-prefix-input label {
  position: absolute;
  left: 1.5rem;
  margin-bottom: 0;
}
.vm-prefix-input input {
  padding-left: 6rem;
}

.vm-company-form-control.form-control {
  height: 5rem;
}
.vm-company-form-control.form-control::placeholder {
  font-family: "SegoeUISemibold";
  font-size: 1.8rem;
}

.custom-file {
  position: relative;
  display: inline-block;
  width: 100%;
  height: 4rem;
  margin-bottom: 0;
}
.custom-file-label {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  z-index: 1;
  height: 4rem;
  padding: 0.375rem 0.75rem;
  font-weight: 400;
  line-height: 2.5;
  color: #495057;
  background-color: #fff;
  border: 1px solid #e2ebfb;
  border-radius: 0.25rem;
}
.custom-file-label::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: 3;
  display: block;
  height: 100%;
  padding: 0;
  line-height: 2;
  color: #495057;
  content: "" !important;
  background-color: transparent;
  border-left: inherit;
  border-radius: 0 0.25rem 0.25rem 0;
}
.custom-file-input {
  height: 4rem;
  line-height: 4rem;
  border: 1px solid #e2ebfb;
  font-size: 1.4rem;
  color: #62cf5d;
  border-radius: 0.5rem;
  padding: 1.1rem 1rem 1rem 1rem;
}
.custom-file-input:focus ~ .custom-file-label {
  color: #62cf5d;
  border: 1px solid #b5ccf5;
  outline: none;
  box-shadow: none;
}

.vm-month-list ul li {
  margin: 0.5rem 0.2rem;
  padding: 0.5rem 1.5rem;
  vertical-align: middle;
  border: 0.1rem solid #e2ebfb;
  border-radius: 2rem;
  color: #282842;
  display: inline-block;
  cursor: pointer;
  transition: all 0.5s ease-in;
}
.vm-month-list ul li.current {
  background-color: #fef493;
  border-color: #fcef7d;
  box-shadow: 0px 0.6rem 1rem 0px rgba(254, 198, 38, 0.36);
  transform: scale(1.1);
}
.vm-month-list ul li:focus {
  background-color: #fef493;
  box-shadow: 0px 0.6rem 1rem 0px rgba(254, 198, 38, 0.36);
  transform: scale(1.1);
}
.vm-month-list ul li:hover {
  background-color: #fef493;
  box-shadow: 0px 0.6rem 1rem 0px rgba(254, 198, 38, 0.36);
  transform: scale(1.1);
}

.vm-choose-icons ul li {
  display: inline-block;
  vertical-align: middle;
  margin: 1rem 0.5rem;
}
.vm-choose-icons ul li.selected a {
  background: #fef493;
  box-shadow: 0px 0.6rem 1rem 0px rgba(254, 198, 38, 0.36);
  transform: scale(1.1);
  border-color: #fcef7d;
}
.vm-choose-icons ul li:hover a {
  background: #ffffff;
  box-shadow: 0px 0.3rem 0.8rem 0px rgba(38, 132, 254, 0.2);
  transform: scale(1.1);
}
.vm-choose-icons ul li a {
  padding: 5px;
  height: 4rem;
  width: 6rem;
  border-radius: 3rem;
  border: 0.1rem solid #e2ebfb;
  transition: all 0.2s ease-in-out;
}

.vm-email-logo ul {
  display: flex;
}
.vm-email-logo ul li {
  padding: 2rem 3rem;
  transition: all 0.2s ease-in-out;
  display: flex;
  align-items: center;
  margin-right: 2rem;
}
.vm-email-logo ul li:hover {
  box-shadow: 0 0.1rem 2.2rem 0 rgba(0, 63, 179, 0.12);
  transform: scale(1.1);
}

.vm-bulk-action-panel ul {
  background-color: #e5eeff;
  margin-left: 1px;
  margin-right: 1px;
  display: flex;
  align-items: center;
  padding: 1rem 2.5rem 1rem 3rem;
}
.vm-bulk-action-panel ul li {
  margin-right: 1rem;
}
.vm-bulk-action-panel ul li.vm-close-bulk-action-panel {
  cursor: pointer;
  margin-right: 2rem;
}
.vm-bulk-action-panel ul li button.btn {
  border-radius: 0.5rem;
  background-color: #ffffff;
  box-shadow: 0px 0.3rem 0.3rem 0px rgba(0, 63, 179, 0.15);
  transition: box-shadow 0.15s ease-in;
  height: 4rem;
  padding: 0rem 1rem;
}
.vm-bulk-action-panel ul li button.btn:hover {
  color: #282842 !important;
  box-shadow: 0px 0.4rem 0.6rem 0px rgba(0, 63, 179, 0.2);
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete {
  background-color: #ff455f;
  color: #ffffff;
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete:hover {
  color: #ffffff !important;
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete svg {
  margin-top: -0.4rem;
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete svg .st0 {
  fill: #ffffff;
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete svg .st1 {
  fill: #E5EEFF;
}
.vm-bulk-action-panel ul li button.btn.vm-btn-delete svg .st3 {
  fill: #D9E8FF;
}
.vm-bulk-action-panel ul li button.btn span {
  position: relative;
  top: 1px;
}
.vm-bulk-action-panel ul li button.btn svg {
  margin-right: 0.2rem;
  position: relative;
  top: 0;
}
.vm-bulk-action-panel ul li button.btn svg.mail-icon {
  position: relative;
  top: -0.3rem;
}
.vm-bulk-action-panel .vm-heavy-label {
  margin-left: auto;
  color: #6d6d8c !important;
}

.vm-contact-grid.table th {
  padding-top: 3rem !important;
  padding-bottom: 3rem !important;
}
.vm-contact-grid.table td {
  padding-top: 2rem !important;
  padding-bottom: 2rem !important;
}
.vm-contact-grid.table td.profile-td {
  padding-left: 0.5rem !important;
  padding-right: 0.5rem !important;
  min-width: 24rem;
}
.vm-contact-grid.table td.profile-td a {
  top: -1rem;
  position: relative;
}
.vm-contact-grid.table td .vm-profile-pic {
  width: 3.2rem;
  height: 3.2rem;
  border-radius: 50%;
  display: inline-block;
  background: #e5eeff;
  text-align: center;
  line-height: 3.2rem;
  color: #6d6d8c;
  font-family: "SegoeUI";
  overflow: hidden;
  margin-right: 0.8rem;
}
.vm-contact-grid.table td .vm-profile-pic img {
  width: 3.5rem;
  height: 3.5rem;
  margin: 0 auto;
  object-fit: cover;
  object-position: center center;
}
.vm-contact-grid.table td.role .vm-customer, .vm-contact-grid.table td.role .vm-lead {
  display: inline-block;
  padding: 0.2rem 1.2rem;
  border-radius: 2rem;
  font-family: "SegoeUI";
  font-size: 1.2rem;
  position: relative;
  top: -0.9rem;
  padding-top: 0;
}
.vm-contact-grid.table td.role .vm-customer {
  background: #62cf5d;
  color: #ffffff;
}
.vm-contact-grid.table td.role .vm-lead {
  background: #81a8d6;
  color: #ffffff;
}

.vm-smart-grid-view-bg {
  background: #fff494 !important;
  border-color: #fcef7d !important;
}
.vm-smart-grid-view-bg svg {
  top: -0.1rem;
  position: relative;
}

.vm-mask {
  position: fixed;
  overflow: hidden;
  width: 100%;
  top: 0;
  bottom: 0;
}
.vm-mask:before, .vm-mask:after {
  content: "";
  position: absolute;
  background: #090909;
  width: 100%;
  height: 100%;
  z-index: 999;
  opacity: 0.6;
  bottom: 0;
  background: #6d6d8c;
}

.vm-set-reminder-check {
  margin-top: 0.8rem !important;
}

.vm-panel-close {
  position: absolute;
  right: 1rem;
  top: 0.5rem;
}

.vm-modal-header .vm-model-close {
  position: absolute;
  right: 2.4rem;
  top: 2.8rem;
}

.modal-body .vm-width-150 {
  width: 15rem !important;
}

.vm-merge-modal-grid .table thead tr th, .vm-merge-modal-grid .table tbody tr td {
  border-left: 1px solid #e2ebfb;
}
.vm-merge-modal-grid .table thead tr th:first-child, .vm-merge-modal-grid .table tbody tr td:first-child {
  border-left: 0;
}

/* srinivas 17-09-2020*/
.vm-associated-contacts ul li {
  margin: 4.3rem 0;
}
.vm-associated-contacts ul li.active .vm-content-close.plus {
  display: none;
}
.vm-associated-contacts ul li.active .vm-content-close.minus {
  display: block;
}
.vm-associated-contacts ul li .vm-contact-show {
  display: none;
}

.vm-content-close {
  cursor: pointer;
  width: 30px;
  height: 30px;
  display: block;
  margin: -15px auto;
  position: relative;
}
.vm-content-close.minus {
  display: none;
}

.sto {
  fill: transparent !important;
}

.vm-heading-header-fixed-height {
  min-height: 55px;
  display: flex;
  align-items: center;
}

.vm-time-icon {
  width: 18px !important;
  height: 18px !important;
}

.vm-profile-pic .btn-primary {
  color: #ffffff !important;
}

.vm-popover-btn {
  color: #ffffff !important;
  position: relative;
  padding-bottom: 0 !important;
}

.vm-opacity-light {
  opacity: 0.4;
}

.vm-whitespace-nowrap {
  white-space: nowrap;
}

.vm-associate-autocomplete .vm-autocomplete-box {
  display: none;
}
.vm-associate-autocomplete .vm-autocomplete-box .list-group {
  margin-top: 0.5rem;
  border: 0.1rem solid #88adef;
  border-radius: 0.5rem;
}
.vm-associate-autocomplete .vm-autocomplete-box .list-group .list-group-item {
  border: none;
  border-bottom: 0.1rem solid #88adef;
  padding-top: 1rem;
  padding-bottom: 1rem;
  cursor: pointer;
}
.vm-associate-autocomplete .vm-autocomplete-box .list-group .list-group-item svg {
  position: relative;
  top: -0.3rem;
}
.vm-associate-autocomplete .vm-autocomplete-box .list-group .list-group-item:last-child {
  border-bottom: none;
}
.vm-associate-autocomplete .vm-autocomplete-added {
  display: none;
}

.vm-timeline-list .vm-timle-name {
  color: #c4d2ec;
}
.vm-timeline-list .vm-event {
  color: #81a8d6;
}

.vm-other-actions li {
  border-bottom: 1px solid #e2ebfb;
}
.vm-other-actions li a {
  padding: 1rem 0;
  display: block;
}
.vm-other-actions li a img {
  position: relative;
  top: -3px;
}
.vm-other-actions li:last-child {
  border-bottom: 0;
}

.vm-title-card .vm-dropdown ul li svg {
  margin-right: 0.4rem !important;
}

.vm-fliter-icon {
  width: 4rem;
  height: 4rem;
  position: fixed;
  right: 0;
  top: 20%;
  background-color: #2684fe;
  display: flex;
  align-items: center;
  justify-content: center;
  border-top-left-radius: 5px;
  border-bottom-left-radius: 5px;
}

.vm-smart-view {
  background: #ffffff;
}
.vm-smart-view .view-icon {
  position: relative;
  top: -1px;
}
.vm-smart-view .vm-smart-view-actions {
  position: absolute;
  right: 1.5rem;
  top: 0.8rem;
}
.vm-smart-view .vm-smart-view-actions .vm-smart-view-add {
  position: absolute;
  right: -16px;
  top: -8px;
}
.vm-smart-view .vm-tick-icon {
  position: relative;
  border-radius: 50% !important;
  margin-left: 1.5rem;
  margin-top: 0.5rem;
  width: 2.6rem;
  height: 2.6rem;
  cursor: pointer;
}

.vm-filter-separator {
  width: 100%;
  position: relative;
  left: 1.5rem;
  margin-top: 5rem !important;
  margin-bottom: 5rem !important;
}
.vm-filter-separator .dropdown-toggle {
  background: #e5eeff !important;
}
.vm-filter-separator.vm-filter-add-separator {
  margin-bottom: 0 !important;
}
.vm-filter-separator .vm-filter-drop-down {
  position: absolute;
  left: 50%;
  margin-left: -4rem;
  top: -2rem;
}
.vm-filter-separator .vm-filter-add-icon {
  position: absolute;
  left: 50%;
  margin-left: -1.4rem;
  top: -1.5rem;
  cursor: pointer;
}

.vm-agency-info-list {
  margin-left: 2rem;
}
.vm-agency-info-list li {
  position: relative;
}
.vm-agency-info-list li label:last-child {
  margin-bottom: 0 !important;
}

.vm-smart-view-drop-list {
  width: 22rem;
}
.vm-smart-view-drop-list ul li {
  position: relative;
}
.vm-smart-view-drop-list ul li:nth-child(1), .vm-smart-view-drop-list ul li:nth-child(2), .vm-smart-view-drop-list ul li:nth-child(3) {
  background-color: #e5eeff;
  border-color: #d0dff9 !important;
}
.vm-smart-view-drop-list ul li a.active {
  color: #6d6d8c !important;
  background: transparent !important;
}
.vm-smart-view-drop-list ul li a.active .vm-pin-icon {
  opacity: 1;
}
.vm-smart-view-drop-list ul li a .vm-pin-icon {
  position: absolute;
  right: 1.4rem;
  opacity: 0.2;
}

.rounded-radius .dropdown-item {
  border-radius: 0.5rem 0.5rem 0.5rem 0.5rem !important;
}

.vm-activities-check .vm-activities-complete {
  position: absolute;
  left: 1.5rem;
  top: 1.5rem;
  display: none;
  transition: all 0.1s ease-in-out;
}
.vm-activities-check:hover .vm-activities-complete {
  display: block;
}

.vm-table-action a {
  padding: 0 0.5rem;
}

.vm-activities-table-grid .dropdown-toggle {
  border-color: transparent !important;
  padding: 0 !important;
  width: 0.6rem !important;
  background: transparent !important;
  height: auto !important;
}
.vm-activities-table-grid .dropdown-toggle::after {
  display: none;
}
.vm-activities-table-grid .dropdown-toggle:focus {
  outline: none;
}
.vm-activities-table-grid .vm-dropdown.vm-multi-select-dropdown {
  width: 0.6rem;
}
.vm-activities-table-grid .vm-dropdown.vm-multi-select-dropdown.show {
  overflow-x: inherit !important;
}
.vm-activities-table-grid .vm-dropdown.vm-multi-select-dropdown.show .dropdown-toggle {
  border-color: transparent !important;
}

.vm-activities-list-view {
  position: relative;
}
.vm-activities-list-view .vm-activities-complete {
  left: inherit;
  right: 0;
  top: 1rem;
}
.vm-activities-list-view.vm-past-due {
  background: url("../img/due-task-pattern-2.svg");
  object-fit: cover;
}

.vm-modal-acc .vm-accordion-arrow {
  top: 1.2rem !important;
}
.vm-modal-acc .vm-time-icon {
  margin-top: 1.3rem !important;
}

.vm-activity-list-view .column:last-child .dropdown-menu {
  left: -11.3rem;
}

.vm-select-month.vm-dropdown.vm-multi-select-dropdown.show .dropdown-toggle {
  border-color: transparent !important;
}
.vm-select-month .dropdown-toggle {
  padding-top: 0 !important;
  padding-left: 0 !important;
  padding-bottom: 0 !important;
  border-color: transparent !important;
  background: transparent !important;
  height: 2.5rem !important;
}

.vm-pipeline-upcoming {
  position: absolute;
  right: 1.2rem;
  top: 1.2rem;
}

.vm-setting-drop .vm-dropdown.vm-multi-select-dropdown.show .dropdown-toggle {
  border-color: transparent !important;
}
.vm-setting-drop .vm-dropdown.vm-multi-select-dropdown.show .dropdown-menu {
  transform: translate3d(-112px, 36px, 0px) !important;
}
.vm-setting-drop .dropdown-toggle {
  border-color: transparent !important;
  padding-left: 0 !important;
  padding-right: 0 !important;
}
.vm-setting-drop .dropdown-toggle:after {
  display: none;
}

.sales-over-view-card {
  margin-bottom: 2rem;
  box-shadow: 0px 2px 2px 0px rgba(0, 63, 179, 0.06), 0px 0px 4px 0px rgba(0, 63, 179, 0.1);
  cursor: grab;
  border: none !important;
  border-top: 0.5rem solid #fef493 !important;
}
.sales-over-view-card:hover {
  box-shadow: 0px 2px 5px 0px rgba(0, 63, 179, 0.1), 0px 20px 15px 0px rgba(0, 63, 179, 0.05);
}
.sales-over-view-card .card-footer {
  background-color: #ffffff;
  border-top: 1px solid #e2ebfb !important;
  border-bottom-left-radius: 0.5rem;
  border-bottom-right-radius: 0.5rem;
}

.add-sales-overview {
  border: 0.2rem dashed #b2cdff;
  background-color: #e5eeff;
  height: 12rem;
  width: 100%;
  border-radius: 0.5rem;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 2rem;
  cursor: pointer;
}

.reports-graph-list {
  float: right;
}
.reports-graph-list li {
  float: left;
  padding-left: 1rem;
  padding-right: 1rem;
}
.reports-graph-list li span {
  width: 1rem;
  height: 1rem;
  border-radius: 0.3rem;
  display: inline-block;
  margin-right: 0.3rem;
}

.graph-bg1 {
  background-color: #fa5565;
}

.graph-color1 {
  color: #fa5565;
}

.graph-bg2 {
  background-color: #3c6d8e;
}

.graph-bg3 {
  background-color: #f79647;
}

.graph-color3 {
  color: #f79647;
}

.graph-bg4 {
  background-color: #604a7b;
}

.graph-bg5 {
  background-color: #f96c6c;
}

.graph-bg6 {
  background-color: #cfdc49;
}

.graph-bg7 {
  background-color: #569cd1;
}

.graph-bg8 {
  background-color: #e45c9f;
}

.graph-bg9 {
  background-color: #f8d457;
}

.vm-service-request-data .vm-service-request-header {
  position: relative;
}
.vm-service-request-data .vm-service-request-header.left-arrow {
  border-top-left-radius: 0 !important;
  border-bottom-left-radius: 0 !important;
}
.vm-service-request-data .vm-service-request-header.left-arrow span {
  padding-left: 1.4rem;
}
.vm-service-request-data .vm-service-request-header.left-arrow:after {
  content: "";
  background: url("../img/arrow-backshape.svg");
  position: absolute;
  height: 100%;
  width: 37px;
  left: -6px;
  top: 0;
}
.vm-service-request-data .vm-service-request-header.right-arrow-hide::before {
  display: none;
}
.vm-service-request-data .vm-service-request-header:before {
  content: "";
  width: 37px;
  height: 100%;
  position: absolute;
  right: -32px;
  top: 1px;
}
.vm-service-request-data .vm-service-request-header:before {
  background: url("../img/arrow.svg");
}

.vm-ser-req-policy-changes li {
  padding-top: 1rem;
  padding-left: 1.2rem;
}
.vm-ser-req-policy-changes li:not(:last-child) {
  margin-bottom: 1rem;
  border-bottom: 0.1rem solid #e2ebfb;
  padding-bottom: 2rem;
}
.vm-ser-req-policy-changes li a {
  display: flex;
  justify-content: flex-start;
  align-items: center;
}
.vm-ser-req-policy-changes li a img {
  margin-right: 1rem;
}

.vm-border-dark {
  border: 1px solid #cadcff;
}

.vm-border-top-success {
  border-top: 0.5rem solid #62cf5d !important;
}

.vm-border-top-warning {
  border-top: 0.5rem solid #fff494 !important;
}

.vm-border-top-danger {
  border-top: 0.5rem solid #ff455f !important;
}

.vm-border-radius-12 {
  border-radius: 1.2rem;
}

.vm-ser-req-policy-changes li {
  padding-top: 1rem;
  padding-left: 1.2rem;
}
.vm-ser-req-policy-changes li:not(:last-child) {
  margin-bottom: 1rem;
  border-bottom: 0.1rem solid laghten(#282842, 1);
  padding-bottom: 2rem;
}
.vm-ser-req-policy-changes li a {
  display: flex;
  justify-content: flex-start;
  align-items: center;
}
.vm-ser-req-policy-changes li a img {
  margin-right: 1rem;
}

/* srinivas 26-11-2020*/
.vm-phone-number a {
  display: inline-block;
  vertical-align: top;
  text-align: center;
}
.vm-phone-number a label {
  display: block;
  font-size: 1rem;
  color: #7887ac !important;
  text-align: left;
  padding: 0 10px;
}
.vm-phone-number small {
  display: inline-block;
  padding: 0.2rem 1.2rem;
  border-radius: 2rem;
  font-family: "SegoeUI";
  font-size: 1.2rem;
  background-color: transparent;
  color: #090909 !important;
  margin: 0 2rem;
}
.vm-phone-number small.vm-new {
  background-color: #fef493;
}
.vm-phone-number small.vm-expired {
  background-color: #ff455f;
  color: #ffffff !important;
}
.vm-phone-number small.vm-active {
  background-color: #62cf5d;
}

.vm-font-size-12 {
  font-size: 1.2rem !important;
}
.vm-font-size-14 {
  font-size: 1.4rem;
}
.vm-font-size-16 {
  font-size: 1.6rem;
}
.vm-font-size-18 {
  font-size: 1.8rem;
}
.vm-font-size-20 {
  font-size: 2rem;
}
.vm-font-size-22 {
  font-size: 2.2rem;
}
.vm-font-size-24 {
  font-size: 2.4rem;
}
.vm-font-size-26 {
  font-size: 2.6rem;
}
.vm-font-size-30 {
  font-size: 3rem;
}
.vm-font-size-32 {
  font-size: 3.2rem !important;
}

.vm-font-primary {
  font-family: "SegoeUI";
}
.vm-font-primary-bold {
  font-family: "SegoeUIBold" !important;
}
.vm-font-primary-semibold {
  font-family: "SegoeUISemibold";
}

h2,
.h2 {
  font-family: "SegoeUIBold";
  font-size: 2rem;
  color: #282842;
}

h3,
.h3 {
  font-family: "SegoeUISemibold";
  font-size: 1.8rem;
  color: #282842;
}

h4,
.h4 {
  font-family: "SegoeUIBold";
  font-size: 1.8rem;
  color: #6d6d8c;
}

.vm-checkbox {
  padding-left: 0;
  position: relative;
  display: flex;
}
.vm-checkbox input,
.vm-checkbox svg {
  width: 1.7rem;
  height: 1.7rem;
}
.vm-checkbox input {
  position: inherit;
  -webkit-appearance: none;
  -moz-appearance: none;
  outline: none;
  background: #ffffff;
  border: none;
  margin: 0;
  padding: 0;
  cursor: pointer;
  transition: box-shadow 0.3s;
  box-shadow: inset 0 0 0 0.2rem #bcbcd6;
}
.vm-checkbox input:checked {
  box-shadow: inset 0 0 0 0.2rem #62cf5d;
}
.vm-checkbox input:disabled {
  box-shadow: inset 0 0 0 0.2rem white;
}
.vm-checkbox input:disabled ~ svg {
  stroke: white;
}
.vm-checkbox svg {
  pointer-events: none;
  fill: none;
  stroke-width: 2px;
  stroke-linecap: round;
  stroke-linejoin: round;
  stroke: #62cf5d;
  position: absolute;
  transform: scale(1) translateZ(0);
}
.vm-checkbox.path input:checked {
  transition-delay: 0.4s;
}
.vm-checkbox.path input:checked + svg {
  stroke-dasharray: 16.1 86.12;
  stroke-dashoffset: 102.22;
}
.vm-checkbox.path svg {
  stroke-dasharray: 86.12;
  stroke-dashoffset: 86.12;
  transition: stroke-dasharray 0.6s, stroke-dashoffset 0.6s;
}
.vm-checkbox label {
  top: -0.2rem;
  position: relative;
  margin-left: 0.7rem;
  text-align: left;
  margin-bottom: 1rem;
}
.vm-checkbox.light input:checked {
  box-shadow: inset 0 0 0 0.2rem #62cf5d;
}
.vm-checkbox.light svg {
  stroke: #62cf5d;
}
.vm-checkbox.form-check-inline {
  display: inline-flex;
  align-items: inherit;
  margin-right: 1rem;
}
.vm-checkbox.form-check-inline label {
  margin-left: 0.4rem;
}

.vm-radio {
  padding-left: 0;
}
.vm-radio label {
  position: relative;
  margin-bottom: 1rem;
  display: flex;
  width: auto;
  align-items: center;
  cursor: pointer;
}
.vm-radio .check {
  margin-right: 0.7rem;
  width: 2rem;
  height: 2rem;
}
.vm-radio .check #border {
  fill: none;
  stroke: #bcbcd6;
  stroke-width: 4;
  stroke-linecap: round;
}
.vm-radio .check #dot {
  fill: #62cf5d;
  transform: scale(0);
  transform-origin: 50% 50%;
}
.vm-radio input {
  display: none;
}
.vm-radio input:checked + label svg #border {
  stroke: #62cf5d;
  stroke-dasharray: 145;
  stroke-dashoffset: 145;
  animation: checked 0.5s ease forwards;
}
.vm-radio input:checked + label svg #dot {
  transform: scale(1);
  transition: transform 0.5s cubic-bezier(0.57, 0.21, 0.69, 3.25);
}
.vm-radio input:disabled + label svg #border {
  stroke: white;
  stroke-dasharray: 145;
  stroke-dashoffset: 145;
  animation: checked 0.5s ease forwards;
}
.vm-radio input:disabled + label svg #dot {
  fill: white;
  transform: scale(1);
  transition: transform 0.5s cubic-bezier(0.57, 0.21, 0.69, 3.25);
}
@keyframes checked {
  to {
    stroke-dashoffset: 0;
  }
}

.vm-dropdown.vm-multi-select-dropdown {
  width: 100%;
  position: relative;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle {
  width: 100%;
  height: 3.6rem;
  color: #282842;
  background: #ffffff;
  border: 0;
  position: relative;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
  z-index: 10;
  padding: 1rem 3.5rem 1rem 1.5rem;
  font-size: 1.4rem;
  cursor: pointer;
  border-radius: 0.5rem;
  text-align: left;
  border: 1px solid #e2ebfb;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:hover {
  background: #ffffff;
  color: #282842;
  border-color: #b5ccf5;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:focus {
  outline: none;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:visited, .vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:active, .vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:focus {
  background: #ffffff;
  border-color: #b5ccf5;
  color: #282842;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle span {
  position: relative;
  top: -0.3rem;
}
.vm-dropdown.vm-multi-select-dropdown > .dropdown-toggle:after {
  content: "";
  position: absolute;
  right: 1.8rem;
  top: 50%;
  border-left: 0.5rem solid transparent;
  border-right: 0.5rem solid transparent;
  border-top: 0.5rem solid #282842;
  transform: rotate(0deg) translateY(-50%);
  transition: all 0.2s cubic-bezier(0.47, 0, 0.745, 0.715);
  transform-origin: 50% 0;
}
.vm-dropdown.vm-multi-select-dropdown.show {
  margin-top: auto !important;
  overflow-x: inherit !important;
}
.vm-dropdown.vm-multi-select-dropdown.show .dropdown-toggle {
  border: 1px solid #e2ebfb !important;
  color: color-1;
}
.vm-dropdown.vm-multi-select-dropdown.show .dropdown-toggle:after {
  margin-top: 0;
  transform: rotate(-180deg) translateY(-50%);
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu {
  font-size: 1.4rem;
  position: absolute;
  z-index: 12;
  top: 100%;
  left: 0;
  right: 0;
  min-width: 100%;
  padding: 0;
  margin-top: 0.2rem;
  margin-bottom: 0.2rem;
  box-sizing: border-box;
  background: #ffffff;
  opacity: 0;
  display: none;
  pointer-events: none;
  box-shadow: 0px 25px 20px 0px rgba(80, 94, 166, 0.22);
  border: 1px solid #e2ebfb !important;
  border-radius: 0.5rem;
  transform: translate3d(0, 1rem, 0rem);
  -webkit-transition: all .2s cubic-bezier(0.47, 0, 0.745, 0.715);
  -moz-transition: all .2s cubic-bezier(0.47, 0, 0.745, 0.715);
  -ms-transition: all .2s cubic-bezier(0.47, 0, 0.745, 0.715);
  -o-transition: all .2s cubic-bezier(0.47, 0, 0.745, 0.715);
  transition: all .2s cubic-bezier(0.47, 0, 0.745, 0.715);
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu[x-placement$=top-start] {
  top: -0.15rem !important;
  border: 1px solid #e2ebfb !important;
  border-bottom: 1px solid #e2ebfb !important;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu.show {
  opacity: 1;
  display: block;
  pointer-events: all;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul {
  padding: 0rem;
  margin-bottom: 0;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li {
  padding: 0;
  border-top: 1px solid #e2ebfb;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li:last-of-type a, .vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li:last-of-type .vm-checkbox {
  border-radius: 0 0 0.5rem 0.5rem;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li:first-of-type {
  border-top: 0px solid #e2ebfb;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li:first-of-type a, .vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li:first-of-type .vm-checkbox {
  border-radius: 0.5rem 0.5rem 0 0;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .dropdown-item {
  padding: 1rem 2rem 1rem 1.5rem;
  white-space: break-spaces;
  color: #282842;
  display: flex;
  align-items: center;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .dropdown-item:hover, .vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .dropdown-item:focus {
  background-color: #2684fe;
  color: #ffffff;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .dropdown-item.active {
  background-color: #2684fe;
  color: #ffffff;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .vm-checkbox {
  margin: 0;
  padding: 1.2rem 1.5rem;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu ul li .vm-checkbox label {
  margin-bottom: 0;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu .form-check-label {
  padding-left: 2.5rem;
}
.vm-dropdown.vm-multi-select-dropdown .dropdown-menu .form-check-input {
  padding-left: 1.7rem;
}
.vm-dropdown.vm-popover-dropdown .dropdown-menu ul li:first-child a {
  border-radius: 0rem 0rem 0rem 0rem !important;
}
.vm-dropdown.vm-popover-dropdown .dropdown-toggle {
  border: none;
  padding-right: 1.2rem;
  padding-left: 1rem;
  font-size: 1.4rem;
  right: 0;
  position: absolute;
  -webkit-transition: none;
  -moz-transition: none;
  -ms-transition: none;
  -o-transition: none;
  transition: none;
}
.vm-dropdown.vm-popover-dropdown .dropdown-toggle:after {
  display: none;
}
.vm-dropdown.vm-popover-dropdown .vm-search-header {
  border-radius: 0.5rem 0 0 0;
}
.vm-dropdown.vm-popover-dropdown .dropdown-menu {
  margin-top: 0.2rem;
  border: 0.1rem solid #e2ebfb;
  position: relative;
}
.vm-dropdown.vm-popover-dropdown .dropdown-menu:before {
  width: 116px;
  height: 40px;
  background-color: #ffffff;
  border: 1px solid #e2ebfb !important;
  border-radius: 0.5rem 0.5rem 0rem 0rem;
  top: 0;
  content: "";
  position: absolute;
  transform: translateY(-100%);
  right: -0.1rem;
}
.vm-dropdown.vm-popover-dropdown .dropdown-menu[x-placement=top-end] {
  margin-top: 0.2rem;
  border-radius: 0.5rem 0.5rem 0rem 0.5rem !important;
}
.vm-dropdown.vm-popover-dropdown .dropdown-menu[x-placement=top-end]:before {
  bottom: 0;
  top: auto;
  transform: translateY(100%);
  border-radius: 0rem 0rem 0.5rem 0.5rem;
}
.vm-dropdown.vm-popover-dropdown.show .dropdown-toggle {
  background-color: transparent;
  border: none !important;
  z-index: 30 !important;
}
.vm-dropdown.vm-popover-dropdown.show .dropdown-menu {
  border-top-right-radius: 0rem;
  margin-right: 0.1rem;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-toggle {
  left: 0rem;
  padding: 1rem !important;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-toggle:after {
  display: block;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-menu {
  border-radius: 0rem 0.5rem 0.5rem 0.5rem !important;
  margin-top: -1px;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-menu:before {
  display: none;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-menu:before {
  left: 0;
}
.vm-dropdown.vm-dropdown-left-button .dropdown-menu ul li a svg {
  margin-right: 0.8rem;
}
.vm-dropdown.vm-dropdown-left-button.show .dropdown-toggle {
  border: 0.1rem solid #e2ebfb !important;
  border-radius: 0.5rem 0.5rem 0 0;
  top: -1px;
}

.vm-input-group {
  position: relative;
}
.vm-input-group .icon-svg {
  width: 16px;
  height: 16px;
  position: absolute;
  right: 1.5rem;
  top: 50%;
  transform: translateY(-50%);
}
.vm-input-group .form-control {
  padding-right: 4rem;
}
.vm-input-group .form-control.dasable {
  pointer-events: none;
  background: #7887ac;
}

.form-group.vm-label-top {
  display: flex;
  flex-wrap: wrap;
  margin-right: -15px;
  margin-left: -15px;
}
.form-group.vm-label-top .col-form-label {
  flex-basis: 100%;
  max-width: 100%;
}
.form-group.text-right .vm-hint {
  text-align: right !important;
  font-family: "Lato";
}

.vm-column-gutter {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}

.form-row {
  margin: 0;
}
.form-row .form-check {
  margin-right: 1rem;
  margin-bottom: 0rem;
}

.vm-is-invalid input.form-control, .vm-is-invalid select.form-control, .vm-is-invalid .custom-select-trigger, .vm-is-invalid .dropdown-toggle, .vm-is-invalid textarea.form-control {
  border: 0.1rem solid #ff455f !important;
}
.vm-is-invalid input.form-control:focus, .vm-is-invalid input.form-control:hover, .vm-is-invalid select.form-control:focus, .vm-is-invalid select.form-control:hover, .vm-is-invalid .custom-select-trigger:focus, .vm-is-invalid .custom-select-trigger:hover, .vm-is-invalid .dropdown-toggle:focus, .vm-is-invalid .dropdown-toggle:hover, .vm-is-invalid textarea.form-control:focus, .vm-is-invalid textarea.form-control:hover {
  border: 0.1rem solid #ff455f !important;
}
.vm-is-invalid .vm-validation-wrap {
  position: relative;
}
.vm-is-invalid .vm-validation-wrap span.vm-validation {
  background: #ff455f !important;
  border-radius: 5px !important;
  display: inline-block !important;
  box-shadow: 0.1rem 0.1rem 0.1rem #aaaaaa;
  margin: 0;
  color: #ffffff;
  font-size: 1.2rem;
  z-index: 1001;
}
.vm-is-invalid .vm-validation-wrap span.vm-validation.vm-top-arrow {
  position: absolute;
  left: -0.5rem;
  top: 0.8rem;
  z-index: 1;
}
.vm-is-invalid .vm-validation-wrap span.vm-validation.vm-top-arrow:before {
  content: "";
  width: 0;
  height: 0;
  border-right: 0.7rem solid transparent;
  border-left: 0.7rem solid transparent;
  border-bottom: 0.7rem solid #ff455f;
  position: absolute;
  top: -0.7rem;
}
.vm-is-invalid .vm-multi-select-dropdown .custom-control .form-check-label.custom-control-label:before {
  border: 0.2rem solid #62cf5d;
}
.vm-is-invalid .custom-control .form-check-label.custom-control-label:before {
  border: 0.2rem solid #ff455f;
}
.vm-is-invalid .custom-control .form-check-label.custom-control-label:before:focus, .vm-is-invalid .custom-control .form-check-label.custom-control-label:before:hover {
  border: 0.2rem solid #ff455f !important;
}

/*END form error messages from Business Essentials*/
.vm-help-icon-inline, .vm-help-icon {
  background-image: url(../img/help-icon.svg);
  background-repeat: no-repeat;
  width: 2rem;
  height: 2rem;
  cursor: pointer;
  flex-shrink: 0;
  display: inline-flex;
  align-self: center;
  position: relative;
  outline: none;
}

.vm-help-icon-inline {
  display: inline-flex;
  vertical-align: middle;
  top: -0.2rem;
  font-size: 1.2rem;
}

.vm-help-align {
  display: flex;
  flex-direction: row;
}

.vm-hint {
  display: block;
  text-align: left !important;
  font-family: "Lato";
  font-size: 1.2rem;
}
.vm-hint-inline {
  display: inline-flex;
  align-items: center;
  padding-left: 0.25rem !important;
  text-align: left !important;
  font-family: "Lato";
  font-size: 1.2rem;
}

.vm-error-inline-text {
  display: block;
  width: 100%;
  margin-top: 0.25rem;
  font-size: 80%;
  color: #ff455f;
}

/* .vm-group-control > div {
  padding-right:0rem; 
} */
.vm-star-required {
  margin-left: 2px;
}
.vm-star-required:after {
  content: "*";
  color: #ff455f;
  font-size: 1.4rem;
  font-weight: bold;
  position: relative;
  top: -3px;
}

.popover {
  font-size: 1.4rem;
}

.vm-list-decimal {
  padding-left: 1.5rem;
}
.vm-list-decimal li {
  display: list-item;
  list-style: decimal;
}
.vm-list-decimal li:last-child {
  padding-bottom: 0;
}

.vm-switch-box {
  display: inline-block;
}
.vm-switch-box.vm-switch-box-bg .vm-switch-label {
  border: solid 1px #e2ebfb;
  border-radius: 3rem;
}
.vm-switch-box .vm-switch-checkbox {
  display: none;
}
.vm-switch-box.vm-switch-red [type=checkbox]:checked + .vm-switch-label::before {
  background: #62cf5d !important;
}
.vm-switch-box.vm-switch-red .vm-switch-label:before {
  background: #ff455f !important;
}
.vm-switch-box .vm-switch-label {
  border-radius: 2rem;
  background-color: #ffffff;
  /*SWITCH OFF COLOR*/
  float: left;
  width: auto;
  height: 2.8rem;
  position: relative;
  -webkit-transition: all 0.3s ease-in 0.1s;;
  -moz-transition: all 0.3s ease-in 0.1s;;
  -ms-transition: all 0.3s ease-in 0.1s;;
  -o-transition: all 0.3s ease-in 0.1s;;
  transition: all 0.3s ease-in 0.1s;;
  cursor: pointer;
  line-height: 2.8rem;
  vertical-align: middle;
}
.vm-switch-box .vm-switch-label:before {
  width: 1.8rem;
  height: 1.8rem;
  margin: 0.5rem;
  border-radius: 50%;
  color: white;
  position: absolute;
  content: "";
  z-index: 2;
  top: 0rem;
  -webkit-transition: all 0.3s ease-in 0s;;
  -moz-transition: all 0.3s ease-in 0s;;
  -ms-transition: all 0.3s ease-in 0s;;
  -o-transition: all 0.3s ease-in 0s;;
  transition: all 0.3s ease-in 0s;;
  right: calc(100% - 28px);
  background: #62cf5d;
  border: 0.15rem solid #ebebeb;
}
.vm-switch-box .vm-switch-label .vm-switch-on, .vm-switch-box .vm-switch-label .vm-switch-off {
  white-space: nowrap;
  padding-right: 3rem;
  overflow: hidden;
  display: block;
  font-size: 1.4rem;
  position: relative;
  user-select: none;
}
.vm-switch-box .vm-switch-label .vm-switch-off {
  top: -2.8rem;
  left: 1rem;
  text-align: right;
  padding-right: 2.2rem;
  padding-left: 2.5rem;
  color: #282842;
}
.vm-switch-box .vm-switch-label .vm-switch-on {
  left: 1.2rem;
  visibility: hidden;
  color: #282842;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label .vm-switch-off {
  visibility: hidden;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label .vm-switch-on {
  visibility: visible;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label {
  background-color: #e5eeff;
  /*SWITCH ON COLORS*/
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label:before {
  right: 0rem;
}

.vm-switch-box .vm-switch-checkbox:disabled + .vm-switch-label {
  cursor: not-allowed;
  opacity: 0.3;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label .vm-switch-off {
  visibility: hidden;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label .vm-switch-on {
  visibility: visible;
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label {
  background-color: #ffffff;
  /*SWITCH ON COLORS*/
}

.vm-switch-box .vm-switch-checkbox:checked + .vm-switch-label:before {
  right: 0rem;
}

.vm-switch-box .vm-switch-checkbox:disabled + .vm-switch-label {
  cursor: not-allowed;
  opacity: 0.3;
}

.vm-datepicker input.form-control {
  background: #ffffff !important;
  border-radius: 0.5rem !important;
  box-shadow: none;
}
.vm-datepicker input.form-control::placeholder {
  color: #282842;
}
.vm-datepicker input.form-control:focus {
  color: #62cf5d;
  outline: none;
  box-shadow: none;
  border: 1px solid #9fbdf2 !important;
}
.vm-datepicker input.form-control:focus::placeholder {
  color: transparent !important;
}

.vm-form-horizontal .vm-column-gutter {
  width: auto;
  /*for full width of textbox*/
}

.vm-column-gutter {
  width: 100%;
  /*for full width of textbox*/
}

.vm-column-gutter {
  width: 100%;
  /*for full width of textbox*/
}

.vm-form-section {
  padding-bottom: 4rem;
}

.vm-upload-btn-wrapper {
  position: relative;
  display: inline-block;
}
.vm-upload-btn-wrapper .vm-btn-primary-outline {
  border: 0.1rem solid #2684fe !important;
  color: #2684fe !important;
  background-color: transparent !important;
  box-shadow: none !important;
  transition: all 0.5s ease-in-out !important;
  cursor: pointer !important;
}
.vm-upload-btn-wrapper .vm-btn-primary-outline:hover {
  background-color: #2684fe !important;
  color: #ffffff !important;
}
.vm-upload-btn-wrapper input[type=file] {
  position: absolute;
  left: 0;
  top: 0;
  opacity: 0;
  z-index: 0;
  height: 40px;
  width: 100%;
  cursor: pointer !important;
}

.custom-file {
  position: relative;
  display: inline-block;
  width: 100%;
  height: 4rem;
  margin-bottom: 0;
}
.custom-file .form-control {
  display: none;
}
.custom-file-label {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  z-index: 1;
  height: 3.6rem;
  line-height: 4rem;
  border: 0.1rem solid #e2ebfb;
  font-size: 1.4rem;
  color: #282842;
  border-radius: 0.5rem;
  padding: 1.5rem;
  background: #ffffff;
}
.custom-file-label::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: 3;
  display: block;
  height: 100%;
  padding: 0;
  line-height: 2;
  color: #495057;
  content: "" !important;
  background-color: transparent;
  border-left: inherit;
  border-radius: 0 0.25rem 0.25rem 0;
}
.custom-file-input {
  height: 4rem;
  line-height: 4rem;
  border: 1px solid #e2ebfb;
  font-size: 1.4rem;
  color: #62cf5d;
  border-radius: 0.5rem;
  padding: 1.1rem 1rem 1rem 1rem;
}
.custom-file-input:focus ~ .custom-file-label {
  color: #62cf5d;
  border: 1px solid #b5ccf5;
  outline: none;
  box-shadow: none;
}

.input-group-append.vm-fileUpload-btn .btn {
  height: 4rem;
  box-shadow: none;
  padding: 0 2rem;
  border-radius: 0 0.5rem 0.5rem 0;
}

.vm-textfield-group {
  display: flex;
  align-items: center;
}
.vm-textfield-group svg {
  margin-left: 1rem;
  cursor: pointer;
}

.vm-bulk-action-panel {
  display: none;
}

.vm-tick-icon {
  width: 20px;
  height: 20px;
  background-color: #62cf5d;
  border-radius: 50px;
  display: flex;
  align-items: center;
  justify-content: center;
}

.vm-inline-edit {
  display: flex;
  border-bottom: 0.1rem solid transparent;
  cursor: pointer;
}
.vm-inline-edit .vm-inline-edit-icon {
  position: absolute;
  right: 0;
  transform: scale(0);
  transition: transform 0.3s ease-in;
}
.vm-inline-edit:hover {
  border-bottom: 0.1rem dashed #e2ebfb;
}
.vm-inline-edit:hover .vm-inline-edit-icon {
  transform: scale(1);
  display: block;
  position: absolute;
  right: 0;
  cursor: pointer;
}
.vm-inline-edit.vm-open-inline:hover {
  border-bottom-color: transparent;
}
.vm-inline-edit.vm-open-inline:hover .vm-inline-edit-icon {
  display: none;
}
.vm-inline-edit .vm-view-mode {
  cursor: pointer;
  display: flex;
}
.vm-inline-edit .vm-edit-mode {
  display: none;
  align-items: center;
  height: 100%;
  width: calc(100% - 50px);
}
.vm-inline-edit .vm-edit-mode .vm-edit-inner {
  display: flex;
  align-items: center;
}
.vm-inline-edit .vm-edit-actions {
  position: absolute;
  right: 0rem;
  display: flex;
  align-items: center;
  margin-left: 0.5rem;
}
.vm-inline-edit .vm-edit-actions span {
  margin-right: 0.4rem;
  animation: show-actions 0.5s ease-in;
  cursor: pointer;
}

.vm-bg-teritary .vm-inline-edit:hover {
  border-bottom: 0.1rem dashed #ccdcf8;
}

@-webkit-keyframes show-actions {
  0% {
    -webkit-transform: scale(0);
    transform: scale(0);
    right: -10rem;
  }
  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
    right: 0rem;
  }
}
@-webkit-keyframes fadeIn {
  0% {
    -webkit-transform: opacity(0);
    transform: opacity(0);
  }
  100% {
    -webkit-transform: opacity(1);
    transform: opacity(1);
  }
}
.vm-dashboard-header .vm-multi-select-dropdown .dropdown-toggle {
  -webkit-transition: cubic-bezier(0.47, 0, 0.745, 0.715);
  -moz-transition: cubic-bezier(0.47, 0, 0.745, 0.715);
  -ms-transition: cubic-bezier(0.47, 0, 0.745, 0.715);
  -o-transition: cubic-bezier(0.47, 0, 0.745, 0.715);
  transition: cubic-bezier(0.47, 0, 0.745, 0.715);
}

.btn-group .btn {
  line-height: 2.5;
  height: 3.4rem;
}
.btn-group .btn-teritary {
  border-color: #e2ebfb;
}
.btn-group .btn-teritary:hover {
  border-color: #e2ebfb;
}

#radioBtn .btn {
  box-shadow: none;
}
#radioBtn .notActive {
  color: #587fc9;
  background-color: #ffffff;
}

@-webkit-keyframes slide-in-top {
  0% {
    -webkit-transform: translateY(-1000px);
    transform: translateY(-1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
    opacity: 1;
  }
}
@keyframes slide-in-top {
  0% {
    -webkit-transform: translateY(-1000px);
    transform: translateY(-1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
    opacity: 1;
  }
}
@-webkit-keyframes slide-in-bottom {
  0% {
    -webkit-transform: translateY(1000px);
    transform: translateY(1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
    opacity: 1;
  }
}
@keyframes slide-in-bottom {
  0% {
    -webkit-transform: translateY(1000px);
    transform: translateY(1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
    opacity: 1;
  }
}
@-webkit-keyframes slide-in-right {
  0% {
    -webkit-transform: translateX(1000px);
    transform: translateX(1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
    opacity: 1;
  }
}
@keyframes slide-in-right {
  0% {
    -webkit-transform: translateX(1000px);
    transform: translateX(1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
    opacity: 1;
  }
}
@-webkit-keyframes slide-in-left {
  0% {
    -webkit-transform: translateX(-1000px);
    transform: translateX(-1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
    opacity: 1;
  }
}
@keyframes slide-in-left {
  0% {
    -webkit-transform: translateX(-1000px);
    transform: translateX(-1000px);
    opacity: 0;
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
    opacity: 1;
  }
}
@keyframes bell-ring {
  0% {
    transform: rotate(0deg);
  }
  2.5% {
    transform: rotate(10deg);
  }
  7.5% {
    transform: rotate(-10deg);
  }
  12.5% {
    transform: rotate(10deg 0.5);
  }
  17.5% {
    transform: rotate(-10deg 0.5);
  }
  22.5% {
    transform: rotate(10deg 0.25);
  }
  25% {
    transform: rotate(0deg);
  }
}
@keyframes spin {
  0% {
    transform: rotate(0deg);
  }
  33% {
    transform: rotate(175deg);
  }
  66% {
    transform: rotate(120deg);
  }
  100% {
    transform: rotate(144deg);
  }
}
@keyframes unspin {
  0% {
    transform: rotate(142deg);
  }
  100% {
    transform: rotate(72deg);
  }
}
.vm-pipeline-count {
  background: #e5eeff;
  border: 7px solid #f8fafe;
  border-radius: 1.5rem;
}
.vm-pipeline-count-list {
  position: relative;
  border-right: 2px solid #ffffff;
  padding: 2rem 0.5rem;
  text-align: center;
}
.vm-pipeline-count-list label {
  color: #6d6d8c;
}
.vm-pipeline-count-list:last-child {
  border-right-color: transparent;
  background: #ff455f;
  border-top-right-radius: 0.7rem;
  border-bottom-right-radius: 0.7rem;
}
.vm-pipeline-count-list:last-child h2, .vm-pipeline-count-list:last-child label {
  color: #ffffff;
}
.vm-pipeline-count-list:last-child:before, .vm-pipeline-count-list:last-child:after {
  display: none;
}
.vm-pipeline-count-list:nth-last-child(2):before {
  background: linear-gradient(90deg, #7797d3 60%, #e03f57 40%);
}
.vm-pipeline-count-list:before, .vm-pipeline-count-list:after {
  content: "";
  position: absolute;
  right: -1rem;
  width: 2rem;
  height: 2rem;
  background: #7797d3;
  border-radius: 50%;
  top: 3rem;
  z-index: 9;
}
.vm-pipeline-count-list:after {
  width: 1.4rem;
  height: 1.4rem;
  background: url("../img/pipeline-list-dot.svg");
  margin-top: 0.5rem;
  right: -0.6rem;
}
.vm-pipeline-details {
  margin-top: 3rem;
}
.vm-pipeline-details li {
  width: 20%;
  float: left;
  padding: 2rem;
  text-align: left;
}
.vm-pipeline-details li:not(:last-child) {
  border-right: 1px solid #e2ebfb;
}

.vm-close-icon {
  display: inline-block;
  background: #ff455f;
  border-radius: 50%;
  text-align: center;
  color: #ffffff !important;
  width: 2.4rem;
  height: 2.4rem;
  line-height: 2.4rem;
}

.vm-contact-accordian .vm-add-icon {
  position: absolute;
  width: 3.6rem;
  height: 5.1rem;
  right: -0.2rem;
  top: 2rem;
}
.vm-contact-accordian .vm-accordion-header .vm-accordion-arrow {
  position: absolute;
  transition: all 0.3s;
  top: 0.6rem;
  left: -0.8rem;
}
.vm-contact-accordian .vm-accordion-header.collapsed a h4 .vm-accordion-arrow {
  transform: rotate(-90deg);
}
.vm-contact-accordian .vm-accordion-header .vm-count h4 {
  color: #2684fe;
}
.vm-contact-accordian.vm-contact-accordian-zero-count .vm-add-icon {
  top: 1.4rem;
}
.vm-contact-accordian.vm-contact-accordian-zero-count .vm-accordion-arrow {
  top: 0.1rem;
}

.vm-contact-left-panel .vm-contact-info .vm-dropdown.vm-multi-select-dropdown .dropdown-toggle {
  padding-right: 1rem;
}
.vm-contact-left-panel .vm-contact-info .vm-dropdown.vm-multi-select-dropdown .dropdown-toggle span {
  top: -1px;
}
.vm-contact-left-panel .vm-contact-info .role {
  background: #81a8d6;
  border-radius: 3rem;
  color: #ffffff;
}
.vm-contact-left-panel .vm-contact-info .role.customer {
  background: #62cf5d;
  color: #ffffff;
}
.vm-contact-left-panel .vm-contact-info header .vm-dropdown-action {
  width: 9.8rem;
  position: absolute;
  right: -1.5rem;
  top: -4.5rem;
}
.vm-contact-left-panel .vm-contact-info header .vm-dropdown-action .dropdown-toggle {
  box-shadow: none;
  border: 1px solid #e2ebfb;
  padding: 0.7rem 3.5rem 0.7rem 1rem;
  font-family: "SegoeUI";
  font-size: 1.4rem;
}
.vm-contact-left-panel .vm-contact-info header .vm-dropdown-action .dropdown-toggle::after {
  right: 1.5rem;
  margin-top: 1px;
}
.vm-contact-left-panel .vm-contact-info header .vm-dropdown-action .dropdown-menu {
  font-family: "SegoeUI";
  font-size: 1.4rem;
}
.vm-contact-left-panel .vm-contact-info header .vm-contact-profile {
  width: 7rem;
  height: 7rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
  margin: 0 auto 1.5rem;
  color: #282842;
  font-size: 2.8rem;
  font-family: "SegoeUISemibold";
  display: flex;
  align-items: center;
  justify-content: center;
  background: #ccddff;
  border: 1px solid #b2cdff;
}
.vm-contact-left-panel .vm-contact-info header .vm-contact-profile img {
  width: 100%;
  height: 100%;
  margin: 0 auto;
  object-fit: cover;
  object-position: center center;
  border-radius: 50% !important;
}
.vm-contact-left-panel .vm-contact-info header .vm-contact-profile img.admin {
  width: 7rem;
  height: 7rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-contact-left-panel .vm-contact-info .contact-detail .vm-separator {
  width: 3rem;
  height: 0.5rem;
  border-radius: 10rem;
  background: #c6daff;
  box-shadow: inset 0.819px 0.574px 1px 0px rgba(255, 255, 255, 0.28), inset -0.707px -0.707px 1px 0px rgba(0, 0, 0, 0.3);
}
.vm-contact-left-panel .vm-contact-info .contact-detail .vm-separator .Rounded_Rectangle_10 {
  background-color: #cadcff;
  position: absolute;
  left: 268px;
  top: 479px;
  width: 20px;
  height: 5px;
  z-index: 228;
}
.vm-contact-left-panel .vm-contact-info .vm-contact-list {
  display: flex;
  justify-content: center;
}
.vm-contact-left-panel .vm-contact-info .vm-contact-list li {
  margin: 0 0.8rem;
}
.vm-contact-left-panel .vm-contact-info .vm-contact-list li a {
  padding: 0.85rem;
  background: #d6e4ff;
  border-radius: 50%;
  border: 1px solid #c6daff;
}
.vm-contact-left-panel .vm-category ul li {
  margin-right: 0.3rem;
  margin-bottom: 1rem;
  display: inline-block;
}
.vm-contact-left-panel .vm-category ul li.list-item {
  display: inline-flex;
  justify-content: flex-start;
  align-items: center;
  border-radius: 3rem;
  color: #6d6d8c;
  text-align: center;
  padding: 0.8rem 1rem;
  cursor: pointer;
  background: #d6e4ff;
  border: 1px solid #c6daff;
}
.vm-contact-left-panel .vm-category ul li.list-item:before {
  content: "";
  width: 0.7rem;
  height: 0.7rem;
  background: #ffffff;
  box-shadow: 0px 3px 3px 0px rgba(102, 118, 149, 0.35) !important;
  display: inline-block;
  position: relative;
  border-radius: 50%;
  margin-right: 0.6rem;
}
.vm-contact-left-panel .vm-category ul li.list-item .vm-input-group .form-control {
  width: 5.5rem;
  height: 3.2rem;
  color: #6d6d8c !important;
  padding: 0;
  margin-right: 0.5rem;
  border: 0;
  background: none;
}
.vm-contact-left-panel .vm-category ul li.list-item .vm-input-group .form-control::placeholder {
  color: #c2c2d0 !important;
}
.vm-contact-left-panel .vm-category ul li.list-item .vm-input-group .form-control:focus {
  background: none;
  color: #6d6d8c !important;
}
.vm-contact-left-panel .vm-category ul li:last-child {
  padding: 0 0.4rem 0rem 1rem;
}
.vm-contact-left-panel .vm-category ul li:nth-last-child(2), .vm-contact-left-panel .vm-category ul li:last-child {
  margin-bottom: 0;
}
.vm-contact-left-panel .vm-owner .dropdown-toggle {
  box-shadow: none !important;
  padding-top: 2rem !important;
  padding-bottom: 2rem !important;
  border: none !important;
  font-size: 1.4rem !important;
  text-align: center !important;
  border-radius: 0 !important;
  height: 5rem;
  background: #c6daff !important;
  border-bottom-left-radius: 0.5rem !important;
  border-bottom-right-radius: 0.5rem !important;
}
.vm-contact-left-panel .vm-owner .dropdown-toggle span {
  margin-right: 0.4rem;
}
.vm-contact-left-panel .vm-owner .dropdown-toggle:after {
  top: 3rem !important;
  right: auto;
}
.vm-contact-left-panel .vm-owner .dropdown-toggle:focus {
  border-color: transparent !important;
}

.vm-add-contact {
  display: none;
}
.vm-add-contact .vm-close-icon {
  position: absolute;
  right: 3.4rem;
  top: 2rem;
}

.vm-line-separator::after {
  content: "";
  width: 0.2rem;
  height: 1rem;
  background: #282842;
  margin: 0 0.5rem 0 0.8rem;
  display: inline-block;
}

.vm-edit-contact .vm-text-dark {
  color: #7797d3;
}
.vm-edit-contact .vm-input-group .form-control {
  color: #9eb4df !important;
  padding: 0;
  margin-right: 0.5rem;
  border: 0;
  border-bottom: 1px dashed #e2ebfb;
  border-radius: 0;
  font-size: 1.4rem;
  font-family: "SegoeUISemibold";
  background: none;
}
.vm-edit-contact .vm-input-group .form-control::placeholder {
  color: #9eb4df !important;
}

.vm-add-edit-contact.vm-add-edit-contact-bg {
  background: #e5eeff;
  border: 0.2rem dashed #d1e1ff;
  padding: 5rem;
}
.vm-add-edit-contact .vm-edit-icon {
  background: #e5eeff;
  padding: 1.5rem;
  display: inline-block;
  border: 0.2rem dashed #d1e1ff;
  border-radius: 0.5rem;
}
.vm-add-edit-contact .vm-edit-icon .icon-svg {
  width: 2.2rem;
  height: 2.4rem;
}

.vm-all-contact .vm-header .vm-multi-select-dropdown {
  width: 8rem;
  margin-top: 0.8rem !important;
  height: 4rem;
}
.vm-all-contact .vm-header .vm-multi-select-dropdown > .dropdown-toggle {
  font-size: 1.8rem;
  font-family: "SegoeUISemibold";
  padding: 0;
  box-shadow: none;
  border: 0;
  border-radius: 0.5rem 0.5rem 0 0;
}
.vm-all-contact .vm-header .vm-multi-select-dropdown .dropdown-menu {
  width: 18rem;
}
.vm-all-contact .vm-header .vm-multi-select-dropdown .dropdown-menu ul li {
  border-top: 0 !important;
}
.vm-all-contact .vm-header .vm-add-icon {
  margin-right: -3.2rem !important;
}
.vm-all-contact li {
  padding: 3rem;
}
.vm-all-contact li.media .media-body h5 {
  font-family: "SegoeUIBold";
  color: #282842;
}
.vm-all-contact li.media .media-body .vm-contact-subject-body {
  color: #7797d3;
}
.vm-all-contact li.media .media-body .vm-contact-date {
  color: #c4d2ec;
  font-size: 1.2rem;
}
.vm-all-contact li.media:nth-child(even) {
  background: #f4f8ff;
}
.vm-all-contact li:not(:last-child) {
  border-bottom: 1px solid #e2ebfb;
}

.vm-profile-card {
  width: 310px;
  background-color: #e5eeff;
  height: calc(100% - 4px);
  position: absolute;
  left: 2px;
  top: 2px;
  bottom: 2px;
  border-radius: 0.5rem 0rem 0rem 0.5rem;
  z-index: 10;
}
.vm-profile-card .vm-profile-img-wrapper {
  display: flex;
  align-items: center;
  justify-content: center;
  margin-top: 5.5rem;
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-remove {
  width: 28px;
  height: 28px;
  background-color: #ff455f;
  color: #ffffff;
  font-family: "SegoeUIBold";
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 9px;
  line-height: 9px;
  position: absolute;
  right: 10px;
  top: 6px;
  cursor: pointer;
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-edit {
  width: 44px;
  height: 44px;
  border-radius: 50%;
  background-color: #ffffff;
  position: absolute;
  bottom: -8px;
  left: 20px;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: box-shadow 0.4s ease-in;
  cursor: pointer;
  -webkit-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-edit:hover {
  -webkit-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
}
.vm-profile-card .vm-profile-img-wrapper img.vm-profile-img {
  width: 16rem;
  height: 16rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-profile-card .vm-profile-body {
  padding: 3.5rem;
}
.vm-profile-card .vm-profile-body .form-control {
  border: none;
}

.vm-contact-more-details {
  position: absolute;
  width: 100%;
  height: 100%;
  background-color: #ffffff;
  top: 0;
  left: 0;
  opacity: 95%;
  display: none;
  transition: all 0.5s;
}
.vm-contact-more-details.view {
  display: block;
  padding: 5rem;
}

.vm-contact-accordian .vm-bg-warning {
  box-shadow: none !important;
}
.vm-contact-accordian .vm-bg-warning .vm-edit-icon {
  border: 0.2rem dashed rgba(9, 9, 9, 0.04) !important;
  background: rgba(9, 9, 9, 0.05) !important;
}
.vm-contact-accordian .vm-accordion-header h4 {
  font-family: "SegoeUISemiBold";
  color: #282842;
}

.vm-contact-bulk-action .vm-bulk-action-panel {
  padding: 3px 0px;
  border-radius: 0.8rem 0.8rem 0 0 !important;
  background-color: #e5eeff;
  border: 3px solid #ffffff;
}

.vm-contact-all-btn {
  margin-left: -1.7rem !important;
}

.vm-add-contact .form-group {
  margin-bottom: 1rem;
}

.vm-record-panel .record-icon {
  margin-top: -0.4rem;
}

.vm-contact-info, .vm-category {
  background: #e5eeff;
  border-bottom: 1px solid #c6daff;
}

.vm-contact-info {
  border-top-left-radius: 0.7rem;
  border-top-right-radius: 0.7rem;
}

.vm-call-option {
  position: absolute;
  left: -180%;
  top: 20rem;
  width: 27rem;
  z-index: 10;
}
.vm-call-option.active {
  left: 85%;
  -webkit-animation: slid5in-left 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  animation: slide-in-left 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
}

.vm-call-info {
  box-shadow: 0px 30px 25px 0px rgba(27, 93, 178, 0.18), 0px 1px 2px 0px rgba(27, 93, 178, 0.08);
  position: absolute;
  z-index: 100;
  width: 100%;
  top: -10rem;
}
.vm-call-info .vm-top {
  top: 6.9rem;
}
.vm-call-info.active {
  top: 6.9rem;
  -webkit-animation: slide-in-top 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  animation: slide-in-top 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
}
.vm-call-info .vm-lead {
  display: inline-block;
  padding: 0.1rem 1.2rem 0.3rem 1.2rem;
  border-radius: 2rem;
  font-family: "SegoeUI";
  font-size: 1.2rem;
  position: relative;
  background: #81a8d6;
  color: #ffffff;
}
.vm-call-info .vm-action ul li {
  display: inline-block;
  padding: 0 0.8rem;
}
.vm-call-info .vm-action ul li a svg {
  width: 3rem;
  height: 2.5rem;
  fill: #ffffff;
}
.vm-call-info .vm-action ul li a svg path {
  fill: #ffffff;
}
.vm-call-info .vm-action ul li a.active {
  border-radius: 10px;
  background: #247beb;
  box-shadow: inset -0.707px -0.707px 1px 0px rgba(255, 255, 255, 0.15), inset 1.638px 1.147px 1px 0px rgba(28, 94, 180, 0.35);
  width: 5rem;
  height: 6rem;
  line-height: 4;
  text-align: center;
  display: block;
}
.vm-call-info-end {
  background: #ff91a0;
}
.vm-call-info-end a {
  padding: 3rem 2rem;
  display: block;
}
.vm-call-info .vm-call-progress button {
  position: relative;
  height: 3.5rem;
}
.vm-call-info .vm-call-progress button span.progress {
  position: absolute;
  width: 40%;
  background: #fef493;
  height: 100%;
  top: 0;
  left: -0.1rem;
  border-top-left-radius: 5rem;
  border-bottom-left-radius: 5rem;
}
.vm-call-info .vm-call-progress button span {
  position: relative;
}

.vm-call-notes {
  width: 35rem;
  position: fixed;
  right: -100%;
  bottom: 1.5rem;
  z-index: 10;
}
.vm-call-notes.active {
  right: 1.5rem;
  -webkit-animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
}

.vm-income-call-flyout {
  width: 35rem !important;
  background: #2684fe !important;
  position: fixed !important;
}
.vm-income-call-flyout .vm-flyout-header {
  background: transparent !important;
}
.vm-income-call-flyout .vm-call-profile {
  margin-top: 6rem;
}
.vm-income-call-flyout .vm-call-profile .vm-pic {
  background: #ffffff;
  width: 10rem;
  height: 10rem;
  position: relative;
  margin: 0 auto;
  border-radius: 100%;
  animation: play 2s ease infinite;
  -webkit-backface-visibility: hidden;
  -moz-backface-visibility: hidden;
  -ms-backface-visibility: hidden;
  backface-visibility: hidden;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 2.5rem;
}
.vm-income-call-flyout .vm-call-profile .vm-pic span {
  background: #ffffff;
  width: 7rem;
  height: 7rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
  color: #6d6d8c;
  font-size: 2.8rem;
  font-family: "SegoeUISemibold";
  display: flex;
  align-items: center;
  justify-content: center;
}
.vm-income-call-flyout .vm-call-profile .vm-pic span img {
  width: 7rem;
  height: 7rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-income-call-flyout .vm-call-profile .vm-call-connection {
  padding-bottom: 5rem;
}
.vm-income-call-flyout .vm-call-profile .vm-call-connection a {
  box-shadow: 0px 5px 5px 0px rgba(251, 73, 98, 0.2);
  border-radius: 50%;
  display: inline-block;
  width: 5rem;
  height: 5rem;
  text-align: center;
  line-height: 3.4;
}
.vm-income-call-flyout .vm-call-profile .vm-call-connection a.receive {
  background: #a2e99c;
}
.vm-income-call-flyout .vm-call-profile .vm-call-connection a.disconnect {
  background: #fc8686;
}
.vm-income-call-flyout .vm-income-call-footer .vm-multi-select-dropdown {
  width: 15rem !important;
  margin: 0 auto;
}
@keyframes play {
  0% {
    transform: scale(1);
  }
  15% {
    box-shadow: 0 0 0 5px rgba(255, 255, 255, 0.4);
  }
  25% {
    box-shadow: 0 0 0 10px rgba(255, 255, 255, 0.4), 0 0 0 20px rgba(255, 255, 255, 0.2);
  }
  25% {
    box-shadow: 0 0 0 15px rgba(255, 255, 255, 0.4), 0 0 0 30px rgba(255, 255, 255, 0.2);
  }
}

.vm-flyouts {
  position: absolute;
  top: 0;
  right: 0;
  background-color: #f2f6ff;
  box-shadow: -20px 0px 20px 0px rgba(51, 82, 140, 0.1);
  transition: 0.3s;
  z-index: 999;
  width: 0;
  display: none;
  min-height: 100vh;
  -webkit-animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
}
.vm-flyouts.active {
  width: 60rem;
  display: block;
}
.vm-flyouts.active .vm-flyout-min-height {
  height: auto;
  overflow: auto;
}
.vm-flyouts .form-group {
  margin-bottom: 1rem;
}
.vm-flyouts .vm-contact-show .form-group {
  margin-bottom: 1rem;
}
.vm-flyouts .vm-flyout-form-separator {
  border-bottom: 1px dashed #d0dff9;
  padding-bottom: 2.5rem;
  position: relative;
}
.vm-flyouts .vm-flyout-form-separator:before {
  content: "";
  width: 100%;
  border-bottom: 1px dashed #ffffff;
  position: absolute;
  bottom: -3px;
  height: 1px;
}
.vm-flyouts h3 {
  color: #323a4d;
}
.vm-flyouts .vm-flyout-footer .row {
  margin-left: 0 !important;
  margin-right: 0 !important;
}
.vm-flyouts .vm-flyout-header {
  position: sticky;
  padding: 2.2rem;
  background: #2684fe;
  z-index: 99;
  width: 60rem;
  top: 0;
  padding-left: 4rem;
}
.vm-flyouts .vm-flyout-header .vm-flyout-close {
  position: absolute;
  left: -5px;
  top: 9px;
  cursor: pointer;
  display: none;
  transition: all 0.5s;
}
.vm-flyouts .vm-flyout-header h2 {
  color: #ffffff;
}
.vm-flyouts .vm-flyout-header .vm-profile-pic {
  width: 5rem;
  height: 5rem;
  background: #ffffff;
  display: inline-block;
  position: absolute;
  border-radius: 50%;
  top: 1rem;
  text-align: center;
  line-height: 4.4rem;
}
.vm-flyouts .vm-flyout-header .vm-profile-pic label {
  font-size: 1.8rem;
  color: #6d6d8c;
  font-family: "SegoeUI";
  margin-bottom: 0;
  position: relative;
  top: 2px;
}
.vm-flyouts .vm-flyout-header .vm-display-name {
  padding-left: 6rem;
}
.vm-flyouts .vm-flyout-header .vm-action-list {
  position: absolute;
  right: 3rem;
  background: #ffffff;
  border-radius: 3rem;
  top: 1.4rem;
  transition: all 0.5s;
}
.vm-flyouts .vm-flyout-header .vm-action-list li {
  display: inline-block;
  border-right: 1px solid #e2ebfb;
}
.vm-flyouts .vm-flyout-header .vm-action-list li:last-child {
  border-right: 0 !important;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a {
  display: inline-block;
  padding: 0.8rem 1.4rem;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a svg, .vm-flyouts .vm-flyout-header .vm-action-list li a img {
  width: 18px;
  height: 18px;
  position: relative;
  top: -2px;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a img {
  top: -4px;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a img.vm-mail-icon, .vm-flyouts .vm-flyout-header .vm-action-list li a img.vm-video-call {
  width: 20px;
  height: 20px;
  top: -1px;
}
.vm-flyouts .vm-info-panel label span.vm-label-text {
  width: 15rem;
  display: inline-block;
}
.vm-flyouts .form-control {
  background: #ffffff !important;
  border-radius: 0.5rem;
}

.vm-add-activity-detail-view, .vm-contact-view {
  display: none;
  box-shadow: -3px 0px 2px 0px rgba(38, 132, 254, 0.04), -30px 0px 30px 0px rgba(38, 132, 254, 0.07);
}
.vm-add-activity-detail-view.vm-company-view:before, .vm-contact-view.vm-company-view:before {
  height: 100%;
}
.vm-add-activity-detail-view .vm-border-left, .vm-contact-view .vm-border-left {
  border-left: 0.1rem solid #c7d8f7;
}

.vm-phone-rotate {
  transform: rotate(260deg);
}

.vm-add-activity-flyout.vm-dual-activity {
  width: 120rem;
}
.vm-add-activity-flyout.vm-dual-activity .vm-add-activity-detail-view {
  display: block;
}
.vm-add-activity-flyout .vm-single-column {
  width: 50% !important;
  float: left;
}
.vm-add-activity-flyout .vm-dual-column {
  display: block;
  float: left;
}
.vm-add-activity-flyout .vm-add-activity-detail-view {
  display: none;
}
.vm-add-activity-flyout .vm-add-activity-detail-view .vm-flyout-close {
  left: -0.4rem;
}
.vm-add-activity-flyout .vm-add-activity-detail-view .vm-single-column {
  width: 100% !important;
}

.vm-flyout-footer {
  border-top: 1px dashed #d0dff9;
  position: relative;
  padding-bottom: 2rem;
}
.vm-flyout-footer:before {
  content: "";
  width: 100%;
  border-bottom: 1px dashed #ffffff;
  position: absolute;
  top: 1px;
  height: 1px;
}
.vm-flyout-footer .vm-flyout-close {
  position: relative;
  left: 50% !important;
}

.vm-timeline-flyout .dropdown-toggle {
  width: 8rem !important;
  top: 0 !important;
  left: 0.6rem !important;
  font-size: 1.8rem !important;
  font-family: "SegoeUISemibold";
}

.show-call-details, .show-task-details {
  display: none;
}

.vm-left-card {
  background: #e5eeff !important;
  border: 1px solid #d1e1ff;
  border-radius: 1rem;
}

.vm-left-card-accordion {
  background: #e5eeff;
}
.vm-left-card-accordion .card {
  border-left: none;
  border-right: none;
  border-radius: 5px;
  border-top: 0.1rem solid #d1e1ff;
  background: transparent !important;
}
.vm-left-card-accordion .card:first-of-type {
  border-top: none;
}
.vm-left-card-accordion .card:last-of-type {
  border-bottom: none;
}
.vm-left-card-accordion .card .card-header {
  background-color: transparent;
  padding-left: 2.5rem;
  padding-right: 0rem;
  border-bottom: none;
}
.vm-left-card-accordion .card .card-header .btn-link {
  font-family: "SegoeUIBold";
  color: #282842;
  text-decoration: none;
  padding-left: 0rem;
}
.vm-left-card-accordion .card .card-header .btn-link .accordion-arrow {
  transform: rotate(90deg);
  transition: transform 0.4s ease-in;
}
.vm-left-card-accordion .card .card-header .btn-link span {
  padding-left: 0.3rem;
}
.vm-left-card-accordion .card .card-header .btn-link.collapsed {
  font-family: "SegoeUI";
  color: #2261db;
}
.vm-left-card-accordion .card .card-header .btn-link.collapsed .accordion-arrow {
  transform: rotate(0deg);
}
.vm-left-card-accordion .card .card-body {
  padding: 0px;
  padding-bottom: 1rem;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item {
  border: none;
  padding: 0px;
  margin: 0rem 0rem;
  background: transparent !important;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item:before {
  width: 0.5rem;
  height: 100%;
  content: "";
  background-color: #2684fe;
  position: absolute;
  left: -0.5rem;
  bottom: 0;
  transition: all 0.3s ease-in-out;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item:first-child {
  margin-top: 0rem;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item.active {
  background-color: #ffffff;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item.active:before {
  visibility: visible;
  height: 100%;
  left: 0;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item.active a {
  color: #7797d3;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item:hover:before {
  left: 0rem;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item:hover a {
  color: #587fc9;
}
.vm-left-card-accordion .card .card-body .list-group .list-group-item a {
  padding: 0.6rem 2.5rem 0.6rem 4.8rem;
  display: block;
}

.vm-border-accordion .card {
  margin-bottom: 1.5rem;
  border: 0.1rem solid #e2ebfb !important;
  border-radius: 0.5rem !important;
}
.vm-border-accordion .card:last-of-type {
  margin: 0rem;
}
.vm-border-accordion .card-header {
  height: 50px;
  display: flex;
  align-items: center;
  background-color: #f4f8ff !important;
  border-bottom: 0.1rem solid #e2ebfb !important;
  margin-bottom: 0rem !important;
  padding-left: 2rem;
  padding-right: 0.4rem;
}
.vm-border-accordion .card-header h2 {
  width: 100%;
}
.vm-border-accordion .card-header h2 .btn {
  display: flex;
  align-items: center;
  padding-right: 0.5rem;
}
.vm-border-accordion .card-header h2 .btn svg {
  margin-right: 0.5rem;
}
.vm-border-accordion .card-header .btn-link {
  font-family: "SegoeUIBold";
  color: #282842;
  text-decoration: none;
  padding-left: 0rem;
}
.vm-border-accordion .card-header .btn-link .accordion-arrow {
  transform: rotate(90deg);
  transition: transform 0.4s ease-in;
}
.vm-border-accordion .card-header.collapsed {
  height: 50px;
  background-color: #ffffff !important;
  margin-bottom: -0.1rem !important;
}
.vm-border-accordion .card-header.collapsed .accordion-arrow {
  transform: rotate(0deg);
}
.vm-border-accordion .card-header.collapsed .vm-li-actions {
  display: none;
}
.vm-border-accordion .card-body {
  background-color: #f4f8ff !important;
  padding: 0rem;
}
.vm-border-accordion .card-body ul li {
  padding: 1rem 2rem 1rem 2.5rem;
  border-bottom: 0.1rem solid #e2ebfb;
  color: #002658;
  display: flex;
  align-items: center;
}
.vm-border-accordion .card-body ul li:nth-child(even) {
  background-color: #eff5ff;
}
.vm-border-accordion .card-body ul li .icon-drag {
  margin-right: 0.5rem;
}
.vm-border-accordion .card-body ul li:last-child {
  border-bottom: none !important;
}
.vm-border-accordion .vm-li-actions {
  display: flex;
  align-items: center;
  margin-left: auto;
}
.vm-border-accordion .vm-li-actions span {
  padding-left: 0.8rem;
  color: #7797d3;
  font-size: 1.4rem;
  font-family: "SegoeUI";
}

.vm-profile-card {
  width: 310px;
  background-color: #fff494;
  height: calc(100% - 4px);
  position: absolute;
  left: 2px;
  top: 2px;
  bottom: 2px;
  border-radius: 0.5rem 0rem 0rem 0.5rem;
  z-index: 10;
}
.vm-profile-card .vm-profile-img-wrapper {
  display: flex;
  align-items: center;
  justify-content: center;
  margin-top: 5.5rem;
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-remove {
  width: 20px;
  height: 20px;
  background-color: #ff455f;
  color: #ffffff;
  font-family: "SegoeUIBold";
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 8px;
  line-height: 8px;
  position: absolute;
  right: 20px;
  top: 10px;
  cursor: pointer;
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-edit {
  width: 44px;
  height: 44px;
  border-radius: 50%;
  background-color: #ffffff;
  position: absolute;
  bottom: -8px;
  left: 20px;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: box-shadow 0.4s ease-in;
  cursor: pointer;
  -webkit-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 5px 5px 0px rgba(38, 132, 254, 0.2);
}
.vm-profile-card .vm-profile-img-wrapper .vm-profile-img-edit:hover {
  -webkit-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -moz-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -ms-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  -o-box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
  box-shadow: 0px 15px 15px 0px rgba(38, 132, 254, 0.2);
}
.vm-profile-card .vm-profile-img-wrapper img.vm-profile-img {
  width: 16rem;
  height: 16rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-profile-card .vm-profile-body {
  padding: 3.5rem;
}
.vm-profile-card .vm-profile-body .form-control {
  border: none;
}

.vm-mini-wizard {
  text-align: center;
}
.vm-mini-wizard ul {
  padding: 0rem 1rem 2rem 1rem;
}
.vm-mini-wizard ul li {
  position: relative;
  padding: 5px;
  display: inline-block;
}
.vm-mini-wizard ul li.current a {
  background-color: #62cf5d;
  box-shadow: 0 0.5rem 0.5rem 0 rgba(73, 134, 61, 0.2);
}
.vm-mini-wizard ul li.current a span {
  color: #62cf5d;
  font-size: 2.2rem;
  font-family: "SegoeUIBold";
  margin: 0;
}
.vm-mini-wizard ul li::after {
  content: "";
  width: 100%;
  height: 1px;
  background-color: #2684fe;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
}
.vm-mini-wizard ul li:last-child::after {
  display: none;
}
.vm-mini-wizard ul li a {
  display: inline-block;
  position: relative;
  width: 10px;
  height: 10px;
  background-color: #2684fe;
  border-radius: 100%;
  color: #7797d3;
  font-size: 1.2rem;
  font-family: "SegoeUIBold";
  box-shadow: 0 0.5rem 0.5rem 0 rgba(38, 132, 254, 0.2);
}
.vm-mini-wizard ul li a span {
  position: absolute;
  top: 100%;
  left: 0;
  right: 0;
  text-align: center;
  margin-top: 0.5rem;
}
.vm-mini-wizard ul li.current:after {
  background: linear-gradient(to left, #2684fe, #62cf5d);
}
.vm-mini-wizard ul li.complete a {
  background-color: #62cf5d;
  color: #62cf5d;
}
.vm-mini-wizard ul li.complete:after {
  background-color: #62cf5d;
}

.vm-dual-list .vm-dual-list-box {
  width: 100%;
  height: auto;
  border: 0.1rem solid #e2ebfb;
  border-radius: 0.5rem;
  min-height: 300px;
}
.vm-dual-list .vm-dual-list-box header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 2rem;
  border-bottom: 0.1rem solid #e2ebfb;
}
.vm-dual-list .vm-dual-list-box header .vm-checkbox label {
  margin-bottom: 0rem;
}
.vm-dual-list .vm-dual-list-box ul {
  position: relative;
}
.vm-dual-list .vm-dual-list-box ul li {
  cursor: pointer;
  border-bottom: 0.1rem solid #e2ebfb;
  padding: 1rem 2.5rem;
  transition: 0.3s ease-in;
  position: relative;
}
.vm-dual-list .vm-dual-list-box ul li.select {
  background-color: #eff5ff;
}
.vm-dual-list .vm-dual-list-box ul li.select:after {
  background-image: url(../img/tick.svg);
  content: "";
  width: 24px;
  height: 20px;
  position: absolute;
  right: 1.5rem;
  background-repeat: no-repeat;
}
.vm-dual-list .vm-dual-list-box ul li:hover {
  background-color: #eff5ff;
}
.vm-dual-list .vm-dual-list-box ul li:last-child {
  border-bottom: none;
}
.vm-dual-list .vm-dual-list-control {
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
}
.vm-dual-list .vm-next-circle {
  border: 0.1rem solid #e2ebfb;
  border-radius: 50px;
  width: 40px;
  height: 40px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  margin: 0.5rem 0;
  transition: 0.3s ease-in;
  background-color: #fef493;
}
.vm-dual-list .vm-next-circle:hover {
  background-color: #ffffff;
}
.vm-dual-list .vm-next-circle.vm-previous-circle {
  transform: rotate(-180deg);
  -webkit-transform: rotate(-180deg);
  -moz-transform: rotate(-180deg);
  -ms-transform: rotate(-180deg);
  -o-transform: rotate(-180deg);
  transform: rotate(-180deg);
  -webkit-transition: transform 0.2s ease-in;
  -moz-transition: transform 0.2s ease-in;
  -ms-transition: transform 0.2s ease-in;
  -o-transition: transform 0.2s ease-in;
  transition: transform 0.2s ease-in;
}

.vm-tabs {
  background: #f2f6ff !important;
}

.vm-card-tabs {
  border-bottom: 0.1rem solid #e2ebfb;
}
.vm-card-tabs .nav-item {
  margin: 0 1rem;
}
.vm-card-tabs .nav-item .nav-link {
  position: relative;
  padding: 1.6rem 1rem;
  color: #282842;
}
.vm-card-tabs .nav-item .nav-link.active {
  border: 0.1rem solid transparent;
  color: #2684fe;
  font-family: "SegoeUIBold";
  background: transparent;
}
.vm-card-tabs .nav-item .nav-link.active:after {
  width: 100%;
  height: 0.3rem;
  background-color: #2684fe;
  border-radius: 2rem;
  content: "";
  position: absolute;
  bottom: -0.2rem;
  left: 0rem;
  z-index: 1;
}
.vm-card-tabs .nav-item .nav-link.active:hover {
  border: 0.1rem solid transparent;
}
.vm-card-tabs .nav-item .nav-link.active:focus {
  border: 0.1rem solid transparent;
}
.vm-card-tabs .nav-item .nav-link:hover {
  border: 0.1rem solid transparent;
}
.vm-card-tabs .nav-item .nav-link:focus {
  border: 0.1rem solid transparent;
}
.vm-card-tabs.slider-tabs .indicator {
  position: absolute;
  top: calc(100% - 0.3rem);
  min-width: 0;
  width: 0;
  height: 0.5rem;
  transition: left 0.3s, width 0.5s;
  background-color: #2684fe;
  border-radius: 2rem;
}

.vm-dashboard-activity-board .vm-activity-bg {
  background: #f7f7fc;
}
.vm-dashboard-activity-board .vm-list-tab {
  border: 1px solid #e2ebfb;
  border-radius: 2rem;
}
.vm-dashboard-activity-board .vm-list-tab li a {
  padding: 0.8rem 1.2rem;
  display: block;
  border-right: 1px solid #e2ebfb;
  color: #282842;
}
.vm-dashboard-activity-board .vm-list-tab li a.active {
  background: #2684fe;
  color: #ffffff;
}
.vm-dashboard-activity-board .vm-list-tab li:first-child .active {
  border-top-left-radius: 2rem;
  border-bottom-left-radius: 2rem;
}
.vm-dashboard-activity-board .vm-list-tab li:last-child a {
  border-right: 0;
}
.vm-dashboard-activity-board .vm-list-tab li:last-child .active {
  border-top-right-radius: 0.5rem;
  border-bottom-right-radius: 0.5rem;
}
.vm-dashboard-activity-board .vm-list-tab li .vm-multi-select-dropdown.show .dropdown-toggle {
  border: 0 !important;
}
.vm-dashboard-activity-board .vm-list-tab li .vm-multi-select-dropdown.show .dropdown-menu {
  top: 0rem !important;
  z-index: 999;
}
.vm-dashboard-activity-board .vm-list-tab li .vm-multi-select-dropdown .dropdown-toggle {
  box-shadow: none;
  padding-left: 1rem;
  border: 0;
  border-top-right-radius: 2rem;
  border-bottom-right-radius: 2rem;
}
.vm-dashboard-activity-board .vm-list-tab li .vm-multi-select-dropdown .dropdown-toggle:after {
  top: 2rem;
}
.vm-dashboard-activity-board .vm-activity-board-list {
  cursor: pointer;
  transition: all 0.5s;
}
.vm-dashboard-activity-board .vm-activity-board-list.vm-due-task {
  background: url("../img/due-task-pattern.png");
  background-repeat: no-repeat;
  background-size: cover;
}
.vm-dashboard-activity-board .vm-activity-board-list .vm-activity-complete-icon {
  display: none;
  transition: all 0.4s;
}
.vm-dashboard-activity-board .vm-activity-board-list .vm-activity-complete-icon {
  position: absolute;
  top: 1.7rem;
  left: 3.6rem;
}
.vm-dashboard-activity-board .vm-activity-board-list .vm-separator {
  background: url("../img/activity-day-separator.svg");
  height: 1.3rem;
}
.vm-dashboard-activity-board .vm-activity-board-complete .vm-activity-complete-icon {
  display: block !important;
}
.vm-dashboard-activity-board .vm-activity-board-complete p, .vm-dashboard-activity-board .vm-activity-board-complete a, .vm-dashboard-activity-board .vm-activity-board-complete .vm-text-dark, .vm-dashboard-activity-board .vm-activity-board-complete label {
  color: #d2d2e4 !important;
}
.vm-dashboard-activity-board .vm-activity-board-complete .vm-activity-image {
  filter: grayscale(100%);
  opacity: 0.5;
}
.vm-dashboard-activity-board .vm-activity-board-complete svg.vm-svg-icon path {
  fill: #7373aa !important;
}
.vm-dashboard-activity-board .vm-due-task {
  background: url("../img/due-task-pattern.png");
  background-repeat: no-repeat;
  background-size: cover;
}
.vm-dashboard-activity-board .vm-separator {
  background: url("../img/activity-day-separator.svg");
  height: 1.6rem;
}

.vm-salesPipeline .vm-header .vm-month.vm-multi-select-dropdown.show .dropdown-toggle {
  border: none !important;
}
.vm-salesPipeline .vm-header .vm-month button {
  padding-bottom: 0;
  padding-top: 0.2rem;
  padding-left: 0 !important;
  height: 2.5rem;
}
.vm-salesPipeline .vm-header .nav .nav-link .vm-svg {
  fill: #87a2d2;
  width: 1.8rem;
  height: 1.9rem;
  transition: 0.2s all ease-in;
}
.vm-salesPipeline .vm-header .nav .nav-link.active {
  background: #e5eeff;
  border-radius: 0.5rem;
  padding: 0.8rem 1rem;
}
.vm-salesPipeline .vm-header .nav .nav-link.active .vm-svg {
  fill: #2684fe;
}
.vm-salesPipeline .column {
  border-right: 0.1rem dashed #b5ccf5;
  position: relative;
}
.vm-salesPipeline .column:last-child::after {
  border-right: 0 !important;
}
.vm-salesPipeline .column header.vm-header {
  padding: 0 1rem;
}
.vm-salesPipeline .column::after {
  content: "";
  border-right: 0.1rem dashed #ffffff;
  position: absolute;
  right: -0.28rem;
  top: 0;
  height: 100%;
}
.vm-salesPipeline .column .vm-list {
  display: flex;
  justify-content: flex-start;
  align-items: center;
  margin: 0;
  padding: 0;
  list-style-position: inside;
}
.vm-salesPipeline .column .vm-list li {
  color: #2b4b86 !important;
}
.vm-salesPipeline .column .vm-list li:not(:first-child) {
  padding-left: 1.8rem;
}
.vm-salesPipeline .column .vm-list li:not(:first-child)::before {
  position: absolute;
  margin-left: -1.2rem;
  padding-right: 1em;
  color: #e5eeff;
  content: "●";
}
.vm-salesPipeline .column .card {
  margin-bottom: 3rem;
  margin-left: 0.5rem;
  margin-right: 0.5rem;
  cursor: grab;
  border: none;
  box-shadow: 0px 2px 2px 0px rgba(0, 63, 179, 0.06), 0px 0px 4px 0px rgba(0, 63, 179, 0.1);
}
.vm-salesPipeline .column .card.vm-negotiating {
  background: url(../img/due-task-pattern.png);
  object-fit: cover;
}
.vm-salesPipeline .column .card .vm-card-footer {
  border-top: 1px solid #e2ebfb !important;
  border-bottom-left-radius: 0.5rem;
  border-bottom-right-radius: 0.5rem;
}
.vm-salesPipeline .column .card:hover {
  box-shadow: 0px 2px 5px 0px rgba(0, 63, 179, 0.1), 0px 20px 15px 0px rgba(0, 63, 179, 0.05);
}
.vm-salesPipeline .column .card .vm-like {
  position: absolute;
  right: 0.5rem;
  top: 0.5rem;
}
.vm-salesPipeline .column .card .vm-like .vm-svg {
  width: 1.8rem;
  height: 1.8rem;
}
.vm-salesPipeline .column .card .vm-dislike {
  position: absolute;
  right: 0.5rem;
  top: 0.5rem;
}
.vm-salesPipeline .column .card .vm-dislike .vm-svg {
  width: 1.8rem;
  height: 1.8rem;
  transform: rotate(180deg);
}
.vm-salesPipeline .column .card .vm-break {
  width: 0;
  height: 0;
  border-style: solid;
  border-width: 0 4.5rem 4.5rem 0;
  border-color: transparent #fff494 transparent transparent;
  position: absolute;
  right: 0;
  top: 0;
}
.vm-salesPipeline .column .card .vm-break .vm-svg {
  width: 1.8rem;
  height: 1.8rem;
  position: relative;
  right: -23px;
  top: 3px;
  transform: rotate(180deg);
}

.sales-pipeline-status {
  position: fixed;
  bottom: 0;
  width: 100%;
  padding-left: 10rem;
  padding-right: 3rem;
  padding-bottom: 2rem;
  padding-top: 2rem;
  background: #ffffff;
}
.sales-pipeline-status .update {
  text-align: center;
  min-height: 1rem;
  border: 0.1rem dashed;
  background: #f7f7fc;
  cursor: pointer;
}
.sales-pipeline-status .update h2 {
  font-size: 3rem;
  line-height: 9rem;
}
.sales-pipeline-status .update.won {
  border-color: #62cf5d;
}
.sales-pipeline-status .update.won h2 {
  color: #62cf5d;
}
.sales-pipeline-status .update.won:hover {
  background: #aee6ac;
}
.sales-pipeline-status .update.won:hover h2 {
  color: #ffffff;
}
.sales-pipeline-status .update.recycle {
  border-color: #2684fe;
}
.sales-pipeline-status .update.recycle h2 {
  color: #2684fe;
}
.sales-pipeline-status .update.recycle:hover {
  background: #8cbefe;
}
.sales-pipeline-status .update.recycle:hover h2 {
  color: #ffffff;
}
.sales-pipeline-status .update.recycle h2 {
  -webkit-text-stroke-color: #2684fe;
}
.sales-pipeline-status .update.lost {
  border-color: #ff455f;
}
.sales-pipeline-status .update.lost h2 {
  color: #ff455f;
}
.sales-pipeline-status .update.lost:hover {
  background: #ffabb7;
}
.sales-pipeline-status .update.lost:hover h2 {
  color: #ffffff;
}
.sales-pipeline-status .update.lost h2 {
  -webkit-text-stroke-color: #ff455f !important;
}
.sales-pipeline-status::after {
  content: "";
  position: absolute;
  background-color: transparent;
  width: 100%;
  height: 4rem;
  z-index: 1000;
}

.ui-state-active {
  background-color: #e5eeff;
}

.column:before {
  position: absolute;
  content: "";
  bottom: 0;
  background-color: transparent;
  pointer-events: none;
  height: 145px;
}

.disable-scrollbars {
  scrollbar-width: none;
  /* Firefox */
  -ms-overflow-style: none;
  /* IE 10+ */
}
.disable-scrollbars::-webkit-scrollbar {
  width: 0px;
  background: transparent;
  /* Chrome/Safari/Webkit */
}

.vm-sales-pipeline-drop .dropdown-toggle {
  height: inherit !important;
}

.won-hover {
  background: #aee6ac !important;
}

.lost-hover {
  background: #ffabb7 !important;
}

.recycle-hover {
  background: #8cbefe !important;
}

.vm-assign-users-nave {
  margin: 15px 0;
}
.vm-assign-users-nave ul {
  display: inline-block;
}
.vm-assign-users-nave ul li {
  display: inline-block;
  margin-right: 10px;
}
.vm-assign-users-nave ul li a {
  padding: 10px 15px;
  background-color: #fef493;
  border-radius: 3rem;
  color: #000;
}

.vm-flyouts {
  position: absolute;
  top: 0;
  right: 0;
  background-color: #f2f6ff;
  box-shadow: -20px 0px 20px 0px rgba(51, 82, 140, 0.1);
  transition: 0.3s;
  z-index: 999;
  width: 0;
  display: none;
  min-height: 100vh;
  -webkit-animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  animation: slide-in-right 0.3s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
}
.vm-flyouts.active {
  width: 60rem;
  display: block;
}
.vm-flyouts.active .vm-flyout-min-height {
  height: auto;
  overflow: auto;
}
.vm-flyouts .form-group {
  margin-bottom: 1rem;
}
.vm-flyouts .vm-contact-show .form-group {
  margin-bottom: 1rem;
}
.vm-flyouts .vm-flyout-form-separator {
  border-bottom: 1px dashed #d0dff9;
  padding-bottom: 2.5rem;
  position: relative;
}
.vm-flyouts .vm-flyout-form-separator:before {
  content: "";
  width: 100%;
  border-bottom: 1px dashed #ffffff;
  position: absolute;
  bottom: -3px;
  height: 1px;
}
.vm-flyouts h3 {
  color: #323a4d;
}
.vm-flyouts .vm-flyout-footer .row {
  margin-left: 0 !important;
  margin-right: 0 !important;
}
.vm-flyouts .vm-flyout-header {
  position: sticky;
  padding: 2.2rem;
  background: #2684fe;
  z-index: 99;
  width: 60rem;
  top: 0;
  padding-left: 4rem;
}
.vm-flyouts .vm-flyout-header .vm-flyout-close {
  position: absolute;
  left: -5px;
  top: 9px;
  cursor: pointer;
  display: none;
  transition: all 0.5s;
}
.vm-flyouts .vm-flyout-header h2 {
  color: #ffffff;
}
.vm-flyouts .vm-flyout-header .vm-profile-pic {
  width: 5rem;
  height: 5rem;
  background: #ffffff;
  display: inline-block;
  position: absolute;
  border-radius: 50%;
  top: 1rem;
  text-align: center;
  line-height: 4.4rem;
}
.vm-flyouts .vm-flyout-header .vm-profile-pic label {
  font-size: 1.8rem;
  color: #6d6d8c;
  font-family: "SegoeUI";
  margin-bottom: 0;
  position: relative;
  top: 2px;
}
.vm-flyouts .vm-flyout-header .vm-display-name {
  padding-left: 6rem;
}
.vm-flyouts .vm-flyout-header .vm-action-list {
  position: absolute;
  right: 3rem;
  background: #ffffff;
  border-radius: 3rem;
  top: 1.4rem;
  transition: all 0.5s;
}
.vm-flyouts .vm-flyout-header .vm-action-list li {
  display: inline-block;
  border-right: 1px solid #e2ebfb;
}
.vm-flyouts .vm-flyout-header .vm-action-list li:last-child {
  border-right: 0 !important;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a {
  display: inline-block;
  padding: 0.8rem 1.4rem;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a svg, .vm-flyouts .vm-flyout-header .vm-action-list li a img {
  width: 18px;
  height: 18px;
  position: relative;
  top: -2px;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a img {
  top: -4px;
}
.vm-flyouts .vm-flyout-header .vm-action-list li a img.vm-mail-icon, .vm-flyouts .vm-flyout-header .vm-action-list li a img.vm-video-call {
  width: 20px;
  height: 20px;
  top: -1px;
}
.vm-flyouts .vm-info-panel label span.vm-label-text {
  width: 15rem;
  display: inline-block;
}
.vm-flyouts .form-control {
  background: #ffffff !important;
  border-radius: 0.5rem;
}

.vm-add-activity-detail-view, .vm-contact-view {
  display: none;
  box-shadow: -3px 0px 2px 0px rgba(38, 132, 254, 0.04), -30px 0px 30px 0px rgba(38, 132, 254, 0.07);
}
.vm-add-activity-detail-view.vm-company-view:before, .vm-contact-view.vm-company-view:before {
  height: 100%;
}
.vm-add-activity-detail-view .vm-border-left, .vm-contact-view .vm-border-left {
  border-left: 0.1rem solid #c7d8f7;
}

.vm-phone-rotate {
  transform: rotate(260deg);
}

.vm-add-activity-flyout.vm-dual-activity {
  width: 120rem;
}
.vm-add-activity-flyout.vm-dual-activity .vm-add-activity-detail-view {
  display: block;
}
.vm-add-activity-flyout .vm-single-column {
  width: 50% !important;
  float: left;
}
.vm-add-activity-flyout .vm-dual-column {
  display: block;
  float: left;
}
.vm-add-activity-flyout .vm-add-activity-detail-view {
  display: none;
}
.vm-add-activity-flyout .vm-add-activity-detail-view .vm-flyout-close {
  left: -0.4rem;
}
.vm-add-activity-flyout .vm-add-activity-detail-view .vm-single-column {
  width: 100% !important;
}

.vm-flyout-footer {
  border-top: 1px dashed #d0dff9;
  position: relative;
  padding-bottom: 2rem;
}
.vm-flyout-footer:before {
  content: "";
  width: 100%;
  border-bottom: 1px dashed #ffffff;
  position: absolute;
  top: 1px;
  height: 1px;
}
.vm-flyout-footer .vm-flyout-close {
  position: relative;
  left: 50% !important;
}

.vm-timeline-flyout .dropdown-toggle {
  width: 8rem !important;
  top: 0 !important;
  left: 0.6rem !important;
  font-size: 1.8rem !important;
  font-family: "SegoeUISemibold";
}

.show-call-details, .show-task-details {
  display: none;
}

.vm-snapshort .icon-svg {
  width: 5rem;
  height: 5rem;
}

.vm-dashboard-phone-icon {
  position: relative;
  left: -1.2rem;
  top: -2.8rem;
}

.vm-dashboard-upcoming-reminder {
  background-color: #fef493;
}

.vm-monthly-goals .vm-goal-icon {
  top: -4.6rem;
  right: 2.7rem;
  z-index: 9;
}
.vm-monthly-goals .vm-strip {
  height: 4rem;
  border: 1px solid #e2ebfb;
  border-top: 0;
  background-color: #ffffff;
  border-radius: 0rem 0rem 0.5rem 0.5rem !important;
  transition: all 0.5s;
}
.vm-monthly-goals .vm-strip.vm-stripe-hide {
  border: transparent;
  height: 0;
  transition: all 0.5s;
}
.vm-monthly-goals .vm-strip.vm-stripe-hide .vm-pull-down {
  top: 1.8rem !important;
}
.vm-monthly-goals .vm-pull-down {
  width: 2.4rem;
  height: 2.4rem;
  border: 3px solid #2684fe;
  display: inline-block;
  border-radius: 50%;
  position: relative;
  top: 2.7rem;
  cursor: pointer;
  box-shadow: 0rem 1rem 0.7rem 0rem rgba(38, 132, 254, 0.14);
  position: relative;
  z-index: 9;
  background: #ffffff;
}
.vm-monthly-goals .vm-pull-down svg {
  fill: #2684fe;
  width: 1rem;
  height: 1rem;
  position: relative;
  top: -2px;
  transition: all 0.5s;
}
.vm-monthly-goals .vm-pull-down svg.rotate {
  transform: rotate(180deg);
  top: -0.3rem;
}
.vm-monthly-goals .vm-pull-down .line {
  height: 1.8rem;
  position: absolute;
  background: #2684fe;
  width: 0.2rem;
  top: -2.1rem;
  left: 0.8rem;
}
.vm-monthly-goals .vm-pull-down .line:before, .vm-monthly-goals .vm-pull-down .line:after {
  content: "";
  width: 100%;
  height: 0.2rem;
  background: #ffffff;
  top: 0.3rem;
  position: absolute;
  left: 0;
}
.vm-monthly-goals .vm-pull-down .line:after {
  top: 1.2rem !important;
}
.vm-monthly-goals .vm-pull-down:before {
  content: "";
}
.vm-monthly-goals .vm-monthly-position {
  background: #e5eeff;
  padding: 2rem 1rem;
  border-radius: 0.5rem;
  width: 7rem;
  float: right;
  position: relative;
  text-align: center;
  color: #282842;
}
.vm-monthly-goals .vm-monthly-position h2 {
  color: #282842;
}
.vm-monthly-goals .vm-monthly-position h2 sup {
  position: relative;
  top: -1rem;
  left: -0.8rem;
  color: #282842;
}
.vm-monthly-goals .vm-deals-pipeline {
  display: none;
}
.vm-monthly-goals .shadow {
  box-shadow: 0px 22px 22px 0px rgba(171, 171, 184, 0.25) !important;
}

.vm-resource-center-arrow {
  position: absolute;
  right: 4.4rem;
  width: 4.4rem;
  height: 4.4rem;
  cursor: pointer;
  margin-top: -1rem;
}

.vm-p1 .vm-profile-card {
  width: 140px;
  background: none !important;
}
.vm-p1 .vm-profile-card .vm-profile-img-wrapper {
  margin: 20px 22px;
}
.vm-p1 .vm-profile-card .vm-profile-img-wrapper img.vm-profile-img {
  width: 12rem;
  height: 12rem;
}
.vm-p1 .vm-profile-card .vm-profile-img-wrapper .vm-profile-img-remove {
  top: 0px;
}

.vm-dashboard-header .vm-datepicker .form-control:focus {
  color: #282842;
}

/*===========
=============HEADER===========*/
body {
  overflow-x: hidden;
}

.vm-primary-header {
  width: 100%;
  background-color: #ffffff;
  box-shadow: 0px 2px 2px 0px rgba(0, 63, 179, 0.1);
  z-index: 100;
  top: 0;
  padding: 1.4rem 1.5rem;
}
.vm-primary-header-logo {
  font-family: "SegoeUIBold";
  font-size: 2.2rem;
  color: #282842 !important;
}
.vm-primary-header .nav .nav-item {
  position: relative;
  margin-left: 2rem;
}
.vm-primary-header .nav .nav-item .form-control {
  border-radius: 2rem;
  border: 1px solid #f0f0f0;
  background: #f7f7f7;
}
.vm-primary-header .nav .nav-item .icon-svg {
  width: 1.6rem;
  height: 1.6rem;
  fill: #282842;
}
.vm-primary-header .nav .nav-item .icon-svg-phone {
  width: 2.1rem;
  height: 2.1rem;
  position: relative;
  top: -0.1rem;
}
.vm-primary-header .nav .nav-item .badge {
  border-radius: 50%;
  -webkit-background-image: linear-gradient( 90deg, rgb(253,60,87) 0%, rgb(251,81,105) 100%);
  -moz-background-image: linear-gradient( 90deg, rgb(253,60,87) 0%, rgb(251,81,105) 100%);
  -ms-background-image: linear-gradient( 90deg, rgb(253,60,87) 0%, rgb(251,81,105) 100%);
  -o-background-image: linear-gradient( 90deg, rgb(253,60,87) 0%, rgb(251,81,105) 100%);
  background-image: linear-gradient( 90deg, rgb(253,60,87) 0%, rgb(251,81,105) 100%);
  box-shadow: 0px 5px 3px 0px rgba(242, 59, 85, 0.4);
  position: absolute;
  width: 1rem;
  height: 1rem;
  display: block;
  top: -0.1rem;
  right: -0.3rem;
}
.vm-primary-header .nav .nav-link {
  padding: 0;
}
.vm-primary-header .nav .nav-link img.admin {
  width: 3.5rem;
  height: 3.5rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-primary-header .nav .nav-link.dropdown-toggle {
  padding-left: 2rem;
}
.vm-primary-header .nav .nav-link.dropdown-toggle.arrow-up::after {
  transform: rotate(180deg) !important;
  margin-top: 1rem;
}
.vm-primary-header .nav .nav-link.dropdown-toggle::after {
  margin-left: 1.2rem;
  border-left: 0.5rem solid transparent;
  border-right: 0.5rem solid transparent;
  border-top: 0.5rem solid #282842;
  transform: rotate(0deg);
  transition: all 0.2s cubic-bezier(0.47, 0, 0.745, 0.715);
  transform-origin: 50% 0;
}
.vm-primary-header .nav .nav-link.dropdown-toggle::before {
  content: "";
  background: #e5eeff;
  width: 0.6rem;
  height: 2.2rem;
  border-radius: 2rem;
  position: relative;
  right: 1.7rem;
}
.vm-primary-header .vm-trial {
  position: relative;
  padding-right: 2.8rem;
}
.vm-primary-header .vm-trial::before {
  content: "";
  background: #e5eeff;
  width: 0.6rem;
  height: 2.2rem;
  border-radius: 2rem;
  position: absolute;
  right: 0.3rem;
  top: 1rem;
}

/* srinvas 20-09-2020*/
.vm-dropdown-profile {
  top: -300px;
  right: 0;
  z-index: 11;
  position: absolute;
  width: 220px;
  transition: all 0.5s ease-in-out;
  box-shadow: 0px 25px 20px 0px rgba(80, 94, 166, 0.22);
}
.vm-dropdown-profile::after {
  content: "";
  position: absolute;
  top: -10px;
  right: 12px;
  width: 20px;
  height: 20px;
  background: #ffffff;
  transform: rotate(45deg);
  z-index: -1;
  box-shadow: 1px -0.2rem 2rem 2px rgba(38, 132, 254, 0.2);
  display: none;
}
.vm-dropdown-profile.p-show {
  top: 70px;
  transition: all 0.5s ease-in-out;
}
.vm-dropdown-profile ul li {
  background-color: #ffffff;
  border-bottom: 1px solid #ffffff;
  box-shadow: inset 0px -1px 0px 0px #e2ebfb;
  padding: 1rem 2rem;
}
.vm-dropdown-profile ul li:first-child {
  border-top-left-radius: 0px !important;
  border-top-right-radius: 0px !important;
}
.vm-dropdown-profile ul li:last-child {
  border-bottom-left-radius: 5px;
  border-bottom-right-radius: 5px;
}
.vm-dropdown-profile ul li a {
  padding-top: 0.4rem;
  padding-bottom: 0.4rem;
}
.vm-dropdown-profile ul li a img {
  margin-right: 0.6rem;
}

.position-sticky {
  position: sticky;
  top: 0;
  z-index: 100;
}

.vm-take-calls {
  width: 47rem;
  background: #2684fe;
  border-radius: 1rem;
  position: absolute;
  right: 10rem;
  box-shadow: -28.284px 28.284px 20px 0px rgba(166, 147, 101, 0.25);
  margin-top: 0.5rem;
}
.vm-take-calls .tab-content {
  width: 100%;
  height: 32rem;
}
.vm-take-calls .nav-pills a {
  background: #2273dd;
  padding: 4.25rem 2.5rem;
  box-shadow: inset 0px 0px 3px 0px rgba(30, 94, 176, 0.6);
  border-radius: 0;
}
.vm-take-calls .nav-pills a:first-child {
  border-top-left-radius: 1.5rem;
}
.vm-take-calls .nav-pills a:last-child {
  border-bottom-left-radius: 1.5rem;
}
.vm-take-calls .nav-pills a.active {
  background: transparent;
  box-shadow: none;
}
.vm-take-calls .vm-call-close {
  position: absolute;
  right: 0;
  top: -0.2rem;
  height: 6.3rem;
  width: 4rem;
  background: #2684fe;
  color: #ff455f;
  cursor: pointer;
  border-top-left-radius: 3rem;
  border-top-right-radius: 3rem;
  text-align: center;
  padding-top: 1rem;
  top: -6.3rem;
  right: 16rem;
  z-index: 100;
}
.vm-take-calls .vm-call-history .vm-profile {
  background: #e5eeff;
  width: 3.2rem;
  height: 3.2rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
  color: #6d6d8c;
  font-size: 1.2rem;
  font-family: "SegoeUISemibold";
  display: flex;
  align-items: center;
  justify-content: center;
}
.vm-take-calls .vm-call-history .vm-profile img.pic {
  width: 3.2rem;
  height: 3.2rem;
  border-radius: 50%;
  object-fit: cover;
  object-position: center center;
}
.vm-take-calls .vm-call-history .vm-call {
  fill: #62cf5d;
  width: 2.2rem;
  height: 2.2rem;
}
.vm-take-calls .vm-call-history .vm-outcall {
  fill: #fef493;
  width: 2.2rem;
  height: 2.2rem;
}
.vm-take-calls .vm-call-history .vm-missedcall {
  fill: #ff455f;
  width: 2.2rem;
  height: 2.2rem;
}
.vm-take-calls .vm-call-history .dropdown-toggle {
  border-color: transparent !important;
  padding: 0 !important;
  width: 0rem !important;
  background: transparent !important;
  height: 0 !important;
}
.vm-take-calls .vm-call-history .dropdown-toggle::after {
  border: none;
}
.vm-take-calls .vm-call-history .dropdown-toggle:focus {
  outline: none;
}
.vm-take-calls .vm-call-history .dropdown-menu {
  box-shadow: 0px 25px 20px 0px rgba(80, 94, 166, 0.22);
  border: 1px solid #e2ebfb !important;
  border-radius: 0.5rem;
  transform: none !important;
  padding: 0;
  margin: 0;
  top: 22px !important;
  left: -140px !important;
}
.vm-take-calls .vm-call-history .dropdown-menu ul {
  padding: 0rem;
  margin-bottom: 0;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li {
  padding: 0;
  border-top: 1px solid #e2ebfb;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li:last-of-type a {
  border-radius: 0 0 0.5rem 0.5rem;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li:first-of-type {
  border-top: 0px solid #e2ebfb;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li:first-of-type a {
  border-radius: 0.5rem 0.5rem 0 0;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li .dropdown-item {
  padding: 1rem 2rem 1rem 1.5rem;
  white-space: break-spaces;
  color: #282842;
  display: flex;
  align-items: center;
  font-size: 1.4rem;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li .dropdown-item:hover, .vm-take-calls .vm-call-history .dropdown-menu ul li .dropdown-item:focus {
  background-color: #2684fe;
  color: #ffffff;
}
.vm-take-calls .vm-call-history .dropdown-menu ul li .dropdown-item.active {
  background-color: #2684fe;
  color: #ffffff;
}

.digit {
  float: left;
  padding: 0.7rem 0;
  font-size: 2.4rem;
  cursor: pointer;
  text-align: center;
  color: #ffffff;
}
.digit.vm-lineheight-0 {
  line-height: 0;
  top: 2rem;
  position: relative;
}

.sub {
  font-size: 1.2rem;
  color: #ffffff;
  opacity: 0.3;
}

#output {
  font-family: "SegoeUIBold";
  font-size: 1.8rem;
  height: 3rem;
  color: #fef493;
}

#call {
  cursor: pointer;
  padding: 1.8rem 0 0 0;
}
#call .vm-call {
  width: 3rem;
}

.botrow {
  text-align: center;
}

.dig {
  cursor: pointer;
}

.vm-primary-nav {
  height: 100%;
  width: 7rem;
  position: fixed;
  z-index: 99;
  top: 0;
  left: 0;
  background-color: #282842;
  overflow-x: hidden;
  border-right: 1px solid #ccddff;
  padding-top: 7rem;
}
.vm-primary-nav .vm-logo {
  background: #2684fe;
  display: block;
  text-align: center;
  color: #ffffff;
  font-family: "SegoeUIBold";
  padding: 1.9rem 0;
  font-size: 2.2rem;
  position: fixed;
  width: 6.9rem;
  top: 0;
  z-index: 99;
}

#vm-primary-content {
  margin-left: 7rem;
  /* Same as the width of the sidenav */
}

.vm-tabbar {
  margin-top: -1rem;
}
.vm-tabbar ul {
  margin: 0;
  padding: 0;
  list-style: none;
  position: relative;
  z-index: 1;
}
.vm-tabbar ul li {
  position: relative;
  margin-bottom: 0.8rem;
  display: flex;
  justify-content: center;
}
.vm-tabbar ul li a {
  cursor: pointer;
  display: block;
  position: relative;
  padding: 1.2rem 0.5rem;
}
.vm-tabbar ul li a div,
.vm-tabbar ul li a span,
.vm-tabbar ul li a svg {
  width: 2.4rem;
  height: 2.4rem;
  display: block;
  -webkit-backface-visibility: hidden;
}
.vm-tabbar ul li a div span {
  bottom: 25%;
  left: 25%;
  position: absolute;
  overflow: hidden;
  z-index: 1;
  transform: scale(0.94);
  transform-origin: 0 100%;
}
.vm-tabbar ul li a div span:first-child svg {
  transition: fill 0.3s ease, stroke 0.3s ease;
  fill: #87A2D2;
  opacity: 50%;
}
.vm-tabbar ul li a div span:last-child {
  height: 0;
  z-index: 5;
  transition: height 0.25s ease;
}
.vm-tabbar ul li a div span:last-child svg {
  fill: #2684fe;
}
.vm-tabbar ul li a strong {
  font-size: 10px;
  font-weight: 600;
  margin-top: 28px;
  transition: all 0.3s ease;
}
.vm-tabbar ul li a:hover div span:first-child svg {
  fill: #2684fe;
}
.vm-tabbar ul li.active {
  position: relative;
  margin-bottom: 1rem;
}
.vm-tabbar ul li.active a {
  z-index: 5;
}
.vm-tabbar ul li.active a div span:last-child {
  height: 2.4rem;
  transition: height 0.3s ease 0.25s;
}
.vm-tabbar ul li.active a strong {
  opacity: 0;
  transform: scale(0.6);
}
.vm-tabbar ul li.active::before {
  content: "";
  width: 4.6rem;
  height: 6.2rem;
  position: absolute;
  top: -0.6rem;
  left: 1.2rem;
  background: url("../img/left-nav-active.svg");
}

@keyframes high {
  0% {
    transform: rotate(0deg) scale(0.94);
  }
  33% {
    transform: rotate(8deg);
  }
  66% {
    transform: rotate(8deg) translateY(-1px);
  }
  100% {
    transform: rotate(0deg) scale(1) translateY(-1px);
  }
}
@keyframes down {
  0% {
    transform: rotate(0deg) scale(1) translateY(-1px);
  }
  33% {
    transform: rotate(8deg);
  }
  66% {
    transform: rotate(8deg) translateY(0);
  }
  100% {
    transform: rotate(0deg) scale(0.94) translateY(0);
  }
}
.vm-more {
  text-align: center;
  margin-bottom: 2.8rem;
  position: relative;
  z-index: 9;
}
.vm-more.open {
  height: 5rem;
}
.vm-more-icon {
  display: block;
  transition: all 0.25s;
}
.vm-more-icon svg {
  width: 2.4rem;
  height: 2.4rem;
  fill: #62cf5d;
  border-radius: 50%;
  box-shadow: 0px 10px 5px 0px rgba(73, 134, 61, 0.2);
}
.vm-more.open .vm-more-icon:before {
  content: "";
  width: 3rem;
  height: 8rem;
  background: url("../img/quick-add-shape-with-close.svg");
  top: -0.8rem;
  left: 2rem;
  z-index: 1;
  position: absolute;
  margin-top: -1rem;
}
.vm-more.open .vm-more-icon svg {
  fill: transparent;
  width: 1.6rem;
  height: 1.6rem;
  z-index: 2;
  position: relative;
}
.vm-more.open .vm-flyout {
  display: block !important;
}
.vm-more.open .vm-flyout:before, .vm-more.open .vm-flyout:after {
  content: "";
  position: absolute;
}
.vm-more.open .vm-flyout:before {
  border-left: 1px solid #0873fe;
  height: calc(100% - .4rem);
  top: 0.2rem;
}

.vm-flyout {
  position: fixed;
  background: #0169f0;
  top: 8rem;
  left: -1rem;
  z-index: 9;
  text-align: left;
  border-radius: 0.5rem;
  animation: slide-right 0.5s cubic-bezier(0.25, 0.46, 0.45, 0.94) both;
  box-shadow: 0px 20px 20px 0px rgba(0, 63, 179, 0.23), -10px 0px 7px 0px rgba(0, 63, 179, 0.1);
}
.vm-flyout li {
  border-bottom: 1px solid #0873fe;
}
.vm-flyout li a {
  color: #ffffff;
  padding: 1.4rem 2.4rem;
  display: block;
  padding-right: 5rem;
}
.vm-flyout li a svg {
  width: 1.6rem;
  height: 1.6rem;
  margin-right: 0.5rem;
  position: relative;
  top: -0.2rem;
}
.vm-flyout li:last-child {
  border-bottom: none;
  box-shadow: none;
}

/**
 * ----------------------------------------
 * animation slide-right
 * ----------------------------------------
 */
@-webkit-keyframes slide-right {
  0% {
    -webkit-transform: translateX(60);
    transform: translateX(60);
  }
  100% {
    -webkit-transform: translateX(60px);
    transform: translateX(60px);
  }
}
@keyframes slide-right {
  0% {
    -webkit-transform: translateX(60);
    transform: translateX(60);
  }
  100% {
    -webkit-transform: translateX(60px);
    transform: translateX(60px);
  }
}
.rounded {
  border-radius: 0.7rem !important;
}

.shadow {
box-shadow:0px 2px 2px rgba(171, 171, 184, 0.24), 0px 0px 5px rgba(171, 171, 184, 0.2) !important;}

p {
  margin-bottom: 0;
}

.btn {
  height: 4rem;
  padding: 0rem 2rem;
  font-family: "Lato";
  font-size: 1.4rem;
  border-radius: 0.3rem;
  transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  line-height: 2;
}
.btn:hover {
  color: transparent;
  text-decoration: none;
}
.btn:focus, .btn.focus {
  outline: 0;
  box-shadow: none;
}

.btn-primary {
  color: #ffffff;
  background-color: #2684fe;
  border-color: transparent;
  box-shadow: 0px 1.5rem 1rem 0px rgba(38, 132, 254, 0.2);
  transition: background-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  border-radius: 3rem;
}
.btn-primary:hover {
  color: #ffffff;
  background-color: #0169f0;
  border-color: transparent;
  box-shadow: 0px 2rem 1.5rem 0px rgba(38, 132, 254, 0.2);
}
.btn-primary:focus, .btn-primary.focus {
  color: #ffffff;
  background-color: #2684fe;
  border-color: transparent;
  box-shadow: 0px 2rem 1.5rem 0px rgba(38, 132, 254, 0.2);
}
.btn-primary.disabled, .btn-primary:disabled {
  color: #ffffff;
  background-color: #59a1fe;
  border-color: transparent;
}
.btn-primary:not(:disabled):not(.disabled):active, .btn-primary:not(:disabled):not(.disabled).active, .show > .btn-primary.dropdown-toggle {
  color: #ffffff;
  background-color: #2684fe;
  border-color: transparent;
  box-shadow: 0px 2rem 1.5rem 0px rgba(38, 132, 254, 0.2);
}
.btn-primary:not(:disabled):not(.disabled):active:focus, .btn-primary:not(:disabled):not(.disabled).active:focus, .show > .btn-primary.dropdown-toggle:focus {
  box-shadow: none;
}

.btn-secondary {
  color: #3f92fe;
  background-color: #ffffff;
  border-color: #8ba9e2;
  border-radius: 3rem;
  padding: 0rem 1.2rem;
  box-shadow: 0rem 0rem 0rem 0px rgba(38, 132, 254, 0.1);
  transition: box-shadow 0.4s ease-in-out;
}
.btn-secondary:hover {
  color: #2684fe;
  background-color: white;
  border-color: #8ba9e2;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-secondary:focus, .btn-secondary.focus {
  color: #2684fe;
  background-color: white;
  border-color: #8ba9e2;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-secondary.disabled, .btn-secondary:disabled {
  color: #2684fe;
  background-color: white;
  border-color: transparent;
}
.btn-secondary:not(:disabled):not(.disabled):active, .btn-secondary:not(:disabled):not(.disabled).active, .show > .btn-secondary.dropdown-toggle {
  color: #2684fe;
  background-color: #ffffff;
  border-color: #8ba9e2;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-secondary:not(:disabled):not(.disabled):active:focus, .btn-secondary:not(:disabled):not(.disabled).active:focus, .show > .btn-secondary.dropdown-toggle:focus {
  box-shadow: none;
}

.btn-teritary {
  color: white;
  background-color: #62cf5d;
  border-color: #aee6ac;
  border-radius: 3rem;
  padding: 0rem 1.2rem;
  box-shadow: 0rem 0rem 0rem 0px rgba(38, 132, 254, 0.1);
  transition: box-shadow 0.4s ease-in-out;
}
.btn-teritary:hover {
  color: #ffffff;
  background-color: white;
  border-color: #aee6ac;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-teritary:focus, .btn-teritary.focus {
  color: #ffffff;
  background-color: white;
  border-color: #aee6ac;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-teritary.disabled, .btn-teritary:disabled {
  color: #ffffff;
  background-color: #88db84;
  border-color: transparent;
}
.btn-teritary:not(:disabled):not(.disabled):active, .btn-teritary:not(:disabled):not(.disabled).active, .show > .btn-teritary.dropdown-toggle {
  color: #ffffff;
  background-color: #62cf5d;
  border-color: #aee6ac;
  box-shadow: 0rem 1rem 0.5rem 0px rgba(38, 132, 254, 0.1);
}
.btn-teritary:not(:disabled):not(.disabled):active:focus, .btn-teritary:not(:disabled):not(.disabled).active:focus, .show > .btn-teritary.dropdown-toggle:focus {
  box-shadow: none;
}

.form-control {
  height: 3.6rem;
  line-height: 4rem;
  border: 1px solid #e5eeff;
  font-size: 1.4rem;
  color: #282842;
  border-radius: 2rem;
  padding: 1.5rem;
  background: #e5eeff;
}
.form-control::placeholder {
  color: #282842;
}
.form-control:focus {
  color: #62cf5d;
  border: 1px solid #e5eeff;
  outline: none;
  box-shadow: none;
}
.form-control:focus::placeholder {
  color: transparent !important;
}

.custom-file {
  position: relative;
  display: inline-block;
  width: 100%;
  height: 4rem;
  margin-bottom: 0;
}
.custom-file-label {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  z-index: 1;
  height: 4rem;
  padding: 0.12rem 1.5rem;
  font-weight: 400;
  line-height: 2.5;
  color: #495057;
  background-color: #fff;
  border: 1px solid #e2ebfb;
  border-radius: 0.25rem;
}
.custom-file-label::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: 3;
  display: block;
  height: 100%;
  padding: 0;
  line-height: 2;
  color: #495057;
  content: "" !important;
  background-color: transparent;
  border-left: inherit;
  border-radius: 0 0.25rem 0.25rem 0;
}
.custom-file-input {
  height: 4rem;
  line-height: 4rem;
  border: 1px solid #e2ebfb;
  font-size: 1.4rem;
  color: #62cf5d;
  border-radius: 0.5rem;
  padding: 1.1rem 1rem 1rem 1rem;
}
.custom-file-input:focus ~ .custom-file-label {
  color: #62cf5d;
  border: 1px solid #b5ccf5;
  outline: none;
  box-shadow: none;
}

.input-group-append.vm-fileUpload-btn .btn {
  height: 4rem;
  box-shadow: none;
  padding: 0 2rem;
}

.border {
  border: 0.1rem solid #e2ebfb !important;
}

.table {
  border-top: 1px solid #e2ebfb;
  border-collapse: separate;
  border-spacing: 0;
  margin-bottom: 0rem !important;
  color: #282842 !important;
}
.table th {
  border: none;
  background-color: #ffffff !important;
  color: #323a4d !important;
  font-family: "SegoeUIBold";
  vertical-align: text-top;
}
.table th, .table td {
  padding: 1.5rem 2rem !important;
  vertical-align: middle !important;
  border-bottom: 1px solid #e2ebfb !important;
}
.table th:first-child, .table td:first-child {
  padding-left: 3rem !important;
}
.table th:last-child, .table td:last-child {
  padding-right: 3rem !important;
}
.table tbody tr td {
  vertical-align: middle !important;
  border-top: none !important;
  background: #ffffff;
}
.table tbody tr:nth-of-type(even) td {
  background-color: white;
}
.table.vm-td-center .vm-checkbox {
  justify-content: center;
}
.table.vm-table-small tr:nth-of-type(even) td {
  background-color: #f9fbff;
}
.table.vm-table-small tr:nth-of-type(odd) td {
  background-color: #f9fbff;
}
.table.vm-table-small tr th, .table.vm-table-small tr td {
  padding: 1rem !important;
}
.table.vm-table-small tr th:first-child, .table.vm-table-small tr td:first-child {
  padding-left: 2.5rem !important;
}
.table.vm-table-small tr th:last-child, .table.vm-table-small tr td:last-child {
  padding-right: 2.5rem !important;
}
.table.table-border-bottom-none tr:last-child td {
  border-bottom: none;
}
.table.table-border-top-none tr:first-child td {
  border-top: none;
}
.table.table-border-top-bottom-none tr:last-child td {
  border-bottom: none !important;
}
.table.table-border-top-bottom-none tr:first-child td {
  border-top: none !important;
}

.form-control-plaintext {
  color: #282842;
  font-family: "SegoeUISemibold";
  font-size: 1.4rem;
}

.form-control {
  height: 3.6rem;
  line-height: 4rem;
  border: 0.1rem solid #e2ebfb;
  font-size: 1.4rem;
  color: #282842;
  border-radius: 0.5rem;
  padding: 1.5rem;
  background: #ffffff;
}
.form-control::placeholder {
  color: #a2a2c7;
}
.form-control:focus {
  color: #282842;
  border: 1px solid #9fbdf2;
  outline: none;
  box-shadow: none;
}
.form-control:focus::placeholder {
  color: transparent !important;
}

textarea.form-control {
  line-height: 1;
}

.col-form-label {
  padding-top: 0px;
  color: #6f6f6f;
}

.input-group-append.vm-fileUpload-btn .btn {
  height: 4rem;
  box-shadow: none;
  padding: 0 2rem;
}

.table {
  border-top: 1px solid #e2ebfb;
  border-collapse: separate;
  border-spacing: 0;
  margin-bottom: 0rem !important;
  color: #323a4d !important;
}
.table th {
  border: none;
  background-color: #ffffff !important;
  color: #323a4d !important;
  font-family: "SegoeUIBold";
  vertical-align: text-top;
}
.table th, .table td {
  padding: 1.5rem 2rem !important;
  vertical-align: middle !important;
  border-bottom: 1px solid #e2ebfb !important;
}
.table th:first-child, .table td:first-child {
  padding-left: 3rem !important;
}
.table th:last-child, .table td:last-child {
  padding-right: 3rem !important;
}
.table tbody tr td {
  vertical-align: middle !important;
  border-top: none !important;
  background-color: #ffffff;
}
.table tbody tr:nth-of-type(even) td {
  background-color: rgba(229, 238, 255, 0.3);
}
.table.vm-td-center .vm-checkbox {
  justify-content: center;
}
.table.table-border-bottom-none tr:last-child td {
  border-bottom: none !important;
}
.table.table-border-top-none tr:first-child td {
  border-top: none !important;
}
.table.table-border-top-bottom-none tr:last-child td {
  border-bottom: none !important;
}
.table.table-border-top-bottom-none tr:first-child td {
  border-top: none !important;
}
.table.vm-table-small tr:nth-of-type(even) td {
  background-color: #f4f8ff;
}
.table.vm-table-small tr:nth-of-type(odd) td {
  background-color: #f4f8ff;
}
.table.vm-table-small tr th, .table.vm-table-small tr td {
  padding: 1rem !important;
}
.table.vm-table-small tr th:first-child, .table.vm-table-small tr td:first-child {
  padding-left: 2.5rem !important;
}
.table.vm-table-small tr th:last-child, .table.vm-table-small tr td:last-child {
  padding-right: 2rem !important;
}
.table.vm-table-no-striped tr:nth-of-type(even) td {
  background-color: #ffffff;
}

.popover {
  border: 1px solid #e2ebfb;
}

.table-responsive {
  overflow-y: hidden;
}

.text-danger {
  color: #ff455f !important;
}

.text-success {
  color: #62cf5d !important;
}

.vm-table-action .dropdown-menu {
  box-shadow: 0px 25px 20px 0px rgba(80, 94, 166, 0.22);
  border: 1px solid #e2ebfb !important;
  border-radius: 0.5rem;
  transform: translate3d(0, 1rem, 0rem);
  padding: 0;
  margin: 0;
}
.vm-table-action .dropdown-menu ul {
  padding: 0rem;
  margin-bottom: 0;
}
.vm-table-action .dropdown-menu ul li {
  padding: 0;
  border-top: 1px solid #e2ebfb;
}
.vm-table-action .dropdown-menu ul li:last-of-type a, .vm-table-action .dropdown-menu ul li:last-of-type .vm-checkbox {
  border-radius: 0 0 0.5rem 0.5rem;
}
.vm-table-action .dropdown-menu ul li:first-of-type {
  border-top: 0px solid #e2ebfb;
}
.vm-table-action .dropdown-menu ul li:first-of-type a, .vm-table-action .dropdown-menu ul li:first-of-type .vm-checkbox {
  border-radius: 0.5rem 0.5rem 0 0;
}
.vm-table-action .dropdown-menu ul li .dropdown-item {
  padding: 1rem 2rem 1rem 1.5rem;
  white-space: break-spaces;
  color: #282842;
  display: flex;
  align-items: center;
  font-size: 1.4rem;
}
.vm-table-action .dropdown-menu ul li .dropdown-item:hover, .vm-table-action .dropdown-menu ul li .dropdown-item:focus {
  background-color: #2684fe;
  color: #ffffff;
}
.vm-table-action .dropdown-menu ul li .dropdown-item.active {
  background-color: #2684fe;
  color: #ffffff;
}
.vm-table-action .dropdown-menu ul li .vm-checkbox {
  margin: 0;
  padding: 1.2rem 1.5rem;
}
.vm-table-action .dropdown-menu ul li .vm-checkbox label {
  margin-bottom: 0;
}

.border-right {
  border-right: 0.1rem solid #e2ebfb !important;
}

.rounded-bottom {
  border-bottom-right-radius: 0.5rem !important;
  border-bottom-left-radius: 0.5rem !important;
}

.vm-pl0 {
  padding-left: 0 !important;
}

.table tr td.vm-pl-0 {
  padding-left: 0 !important;
}
.table tr td.border-bottom-0 {
  border-bottom: 0 !important;
}

.breadcrumb {
  display: -ms-flexbox;
  display: flex;
  -ms-flex-wrap: wrap;
  flex-wrap: wrap;
  padding: 0 !important;
  margin-bottom: 0 !important;
  list-style: none;
  background-color: transparent;
  border-radius: 0.25rem;
}

.breadcrumb-item {
  margin-top: 0.5rem;
  color: #282842 !important;
  font-family: "SegoeUISemibold";
}
.breadcrumb-item.active {
  font-family: "SegoeUI";
}
.breadcrumb-item::before {
  display: inline-block !important;
  content: "" !important;
  background: url(../img/right-arrow.svg) no-repeat;
  width: 1.2rem;
  margin-top: 0.4rem;
  margin-right: 0.5rem;
}

.vm-border-accordion .table {
  background: #ffffff;
  border-radius: 0.8rem;
  overflow: hidden;
}

.rounded-top {
  border-top-left-radius: 0.7rem !important;
  border-top-right-radius: 0.7rem !important;
}

/*# sourceMappingURL=main.cs.map */

import { Routes, Route } from "react-router-dom";
import "./App.css";
import React from "react";
import ListProduct from "./component/ListProduct";
import DetailProduct from "./component/DetailProduct";
function App() {
  return (
    <html>
      <head>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script
          src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
          integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
          crossorigin="anonymous"
        ></script>
        <script
          src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"
          integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"
          crossorigin="anonymous"
        ></script>
        <script
          src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"
          integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"
          crossorigin="anonymous"
        ></script>

        <link
          rel="stylesheet"
          href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"
        />
        <link
          rel="stylesheet"
          href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"
          crossorigin="anonymous"
        ></link>
      </head>
      <body>
        <div className="container-fluid">
          <div className="header row">
            <div className="logo col-md-2">
              <img
                src="https://trackstore.qodeinteractive.com/wp-content/uploads/2017/11/Logo-light-green.png"
                width="90"
                height="50"
                alt="light logo"
              />
            </div>
            <div className="menu col-md-10">
              <ul>
                <li>
                  <a href="#">
                    <span></span>
                    HOME
                  </a>
                </li>
                <li>
                  <a href="#">
                    PAGES
                    <span></span>
                  </a>
                </li>
                <li>
                  <a href="#">
                    SHOP
                    <span></span>
                  </a>
                </li>
                <li>
                  <a href="#">
                    BLOG
                    <span></span>
                  </a>
                </li>
                <li>
                  <a href="#">
                    <span></span>
                    PORTFOLIO
                  </a>
                </li>
                <li>
                  <a href="#">
                    ELEMENTS
                    <span></span>
                  </a>
                </li>
                <li>
                  <a id="login" href="#">
                    LOGIN
                  </a>
                </li>
                <li>
                  <a href="#">
                    <img
                      src="https://banner2.cleanpng.com/20180705/azf/kisspng-shopping-cart-software-computer-icons-shopping-icon-5b3eb003bbc062.574139001530834947769.jpg"
                      width="40"
                      height="40"
                    />
                  </a>
                </li>
                <li>
                  <a href="#">
                    <img
                      src="https://i2.wp.com/www.thinkafrica.fi/wp-content/uploads/2019/04/search-icon.png?fit=1200%2C1200&amp;ssl=1&amp;w=640"
                      alt="search-icon – Think Africa"
                      width="40"
                      height="40"
                    />
                  </a>
                </li>
                <li>
                  <a href="#">
                    <img
                      src="https://www.pinclipart.com/picdir/middle/532-5328945_menu-bar-icon-white-clipart-png-download-menu.png"
                      alt="Menu Bar Icon White Clipart , Png Download - Menu 3 Bar Png Transparent Png  (#5328945) - PinClipart"
                      width="40"
                      height="40"
                    />
                  </a>
                </li>
              </ul>
            </div>
          </div>
          <div className="main row">
            <div className="container">
              <Routes>
                <Route path="/" element={<ListProduct />} />
                <Route path="/DetailProduct" element={<DetailProduct />} />
              </Routes>
            </div>
          </div>
          <div className="footer row">
            <div className="container">
              <div className="card border-secondary cardfooter">
                <div className="card-body">
                  <div className="row">
                    <div className="col-md-2">
                      <div className="mt-3">
                        <strong>FIND A STORE</strong>
                      </div>
                      <div className="mt-3">
                        <a href="#">
                          <strong>SIGN UP FOR EMAIL</strong>
                        </a>
                      </div>
                      <div className="mt-3">
                        <a href="#">
                          <strong>BECOME A MEMBER</strong>
                        </a>
                      </div>
                      <div className="mt-3">
                        <a href="#">
                          <strong>STUDENT DISCOUNT</strong>
                        </a>
                      </div>
                    </div>
                    <div className="col-md-2">
                      <div class="mt-3">
                        <strong>SERVICE</strong>
                      </div>
                      <div className="mt-3">
                        <img
                          src="https://trackstore.qodeinteractive.com/wp-content/uploads/2017/10/footer-cards.png"
                          width="150"
                          height="48"
                        />
                      </div>
                    </div>
                    <div className="col-md-2 ">
                      <div class="mt-3">
                        <strong>SERVICES</strong>
                      </div>
                      <div className="menu2">
                        <ul className="mt-3">
                          <li>
                            <a href="#">
                              <span></span>
                              Carears
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Istore finder
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Account
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Contact Us
                            </a>
                          </li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-md-2 ">
                      <div class="mt-3">
                        <strong>FIND A STORE</strong>
                      </div>
                      <div className="menu2 mt-3">
                        <ul>
                          <li>
                            <a href="#">
                              <span></span>
                              OrderStatus
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Delivery
                            </a>
                          </li>
                        </ul>
                        <ul className="mt-3">
                          <li>
                            <a href="#">
                              <span></span>
                              Returns
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Payment Options
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Contact Us
                            </a>
                          </li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-md-2 ">
                      <div className="mt-3">
                        <strong>NEW ABOUT</strong>
                      </div>
                      <div className="menu2">
                        <ul className="mt-3">
                          <li>
                            <a href="#">
                              <span></span>
                              Carears
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Investors
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#">
                              <span></span>
                              Sustainable Innovation
                            </a>
                          </li>

                          <li className="mt-3">
                            <a href="#" s>
                              <span></span>
                              UK Modern Slavery
                            </a>
                          </li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-md-2">
                      <div className="mt-3">
                        <strong>SERVICE</strong>
                      </div>
                      <div className="mt-3">
                        <div className="row">
                          <div className="col-md-3">
                            <img
                              src="https://www.vhv.rs/dpng/d/80-808195_youtube-black-and-white-icons-png-transparent-png.png"
                              alt="Youtube Black And White Icons Png, Transparent Png - vhv"
                              width="20"
                              height="20"
                            />
                          </div>
                          <div className="col-md-3">
                            <img
                              src="https://i.pinimg.com/736x/7c/cb/40/7ccb40e2fa23d39346cc9dc8691d68b3.jpg"
                              alt="Facebook Logo Red Transparent - Fb Icon White Png Clipart in 2021 | Facebook  logo transparent, Facebook and instagram logo, Facebook icons"
                              width="20"
                              height="20"
                            />
                          </div>
                          <div className="col-md-3">
                            <img
                              src="https://e7.pngegg.com/pngimages/46/1008/png-clipart-computer-icons-twitter-leaf-logo.png"
                              alt="Silhouette Computer Icons Twitter, twitter, logo, monochrome png | PNGEgg"
                              width="20"
                              height="20"
                            />
                          </div>
                          <div className="col-md-3">
                            <img
                              src="https://img.favpng.com/18/3/11/computer-icons-linkedin-png-favpng-GgCihq48SAGYiUvbtXCDyZ2m8.jpg"
                              alt="LinkedIn, PNG, 2048x2048px, Linkedin, Black And White, Brand, Logo, Symbol  Download Free"
                              width="20"
                              height="20"
                            />
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div className="card-footer">
                  <p>© 2017 Qode Interactive, All Rights Reserved</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </body>
    </html>
  );
}

export default App;

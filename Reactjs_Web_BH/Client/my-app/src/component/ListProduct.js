import React from "react";
export default function ListProduct() {
  return (
    <div>
      <div className="banner row d-flex justify-content-center align-items-center">
        <div className="col-md-9 text-left p-0">
          <h1>
            <strong class="a">SHOP</strong>
          </h1>
        </div>
        <div className="col-md-3 text-right p-0">
          <h2>Home</h2>
        </div>
      </div>
      <div className="content row">
        <div className="contentleft col-md-9">
          <div className="show col-md-4 text-left"></div>
          <div className="col-md-5"></div>
          <div className="col-md-3 text-right">
            <div className="dropdown text-right">
              <select>
                <option>option1</option>
                <option>option2</option>
                <option>option3</option>
              </select>
            </div>
          </div>
        </div>
      </div>
      <div className="row"></div>
    </div>
  );
}

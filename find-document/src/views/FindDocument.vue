<template>
    <div class="row">
        <div class="col-sm-3">
            <a href="#">
                   <div class="card-title"> </div>
                <img src="@/assets/images/h1.jpg" class="card-img-top" alt="banner">
                    <img src="@/assets/images/h2.jpg" class="card-img-top" alt="banner">
                     <img src="@/assets/images/h3.jpg" class="card-img-top" alt="banner">
                 <div class="card-title"> </div>
                <img src="@/assets/images/roi-giay-to1.jpg" class="card-img-top" alt="banner">
                   <div class="card-title"> </div>
                <img src="@/assets/images/noiquy1.png" class="card-img-top" alt="banner">
                  <img src="@/assets/images/Noiquy.jpg" class="card-img-top" alt="banner">
                
            </a>
        </div>
        <div class="col-sm-6">
              <div class="card-title"> <label class="text-danger" role="alert">Nếu thông tin của bạn đưa ra là không chính xác, bạn có thể đối diện với pháp luật  ________HÃY THẬT SỰ LÀM VIỆC TỐT</label></div>
            <h4 class="text-info">Thông tin về bạn</h4>
            <div class="form-group row">
                <label class="col-sm-4 col-form-label">Họ tên</label>
                <div class="col-sm-8">
                    <input v-model="requestModel.hoTen" type="text" class="form-control" placeholder="họ tên của bạn là gì??...">
                </div>
            </div>
            <div class="form-group row">
                <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label">Địa chỉ liên hệ</label>
                <div class="col-sm-8">
                    <select v-model="requestModel.maTinhNn" @change="onChangeTinh()" class="form-control" >
                        <option v-for="(item, index) in dataInit.dsTinh" v-bind:key="index" v-bind:value="item.maTinh">
                            {{item.tenTinh}}
                        </option>
                    </select>

                    <select v-model="requestModel.maHuyenNn" @change="onChangeHuyen()" class="form-control mt-1">
                        <option v-for="(item, index) in dataInit.dsHuyen" v-bind:key="index" v-bind:value="item.maHuyen">
                            {{item.tenHuyen}}
                        </option>
                    </select>

                    <select v-model="requestModel.maXaNn"  class="form-control mt-1">
                        <option v-for="(item, index) in dataInit.dsXa" v-bind:key="index" v-bind:value="item.maXa">
                            {{item.tenXa}}
                        </option>
                    </select>
                </div>
            </div>

            <div class="form-group row">
                <label class="col-sm-4 col-form-label">Số điện thoại liên hệ</label>
                <div class="col-sm-8">
                    <input v-model="requestModel.soDienThoai" type="text" class="form-control" placeholder="Đây là thông tin giúp người thất lạc giấy tờ tìm thấy bạn">
                </div>
            </div>

                <h4 class="text-info">Thông tin về giấy tờ nhặt được </h4>
                <div class="form-group row">
                        
                                <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label">Loại giấy tờ</label>
                                <div class="col-sm-8">
                                    <select v-model="requestModel.maLoai" class="form-control" id="exampleFormControlSelect1">
                                        <option v-for="(item, index) in dataInit.loaiGiayTo" v-bind:key="index" v-bind:value="item.maLoai">
                                            {{item.tenLoai}}
                                        </option>
                                    </select>
                                </div>
                            </div>
                                <div class="form-group row">       
                    <label class="col-sm-4 col-form-label">Ngày nhặt được</label>
                    <div class="col-sm-8">
                        <input v-model="requestModel.ngayNhat" type="date" class="form-control" placeholder="Ngày...">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label"> Nơi bạn nhặt được giấy tờ</label>
                    <div class="col-sm-8">
                        <select v-model="requestModel.maTinh" @change="changeTinhZ()" class="form-control">
                            <option v-for="(item, index) in dataInit.dsTinhZ" v-bind:key="index" v-bind:value="item.maTinh">
                                {{item.tenTinh}}
                            </option>
                        </select>

                        <select v-model="requestModel.maHuyen" @change="changeHuyenZ()" class="form-control mt-1" >
                            <option v-for="(item, index) in dataInit.dsHuyenZ" v-bind:key="index" v-bind:value="item.maHuyen">
                                {{item.tenHuyen}}
                            </option>
                        </select>

                        <select v-model="requestModel.maXa"  class="form-control mt-1" >
                            <option v-for="(item, index) in dataInit.dsXaZ" v-bind:key="index" v-bind:value="item.maXa">
                                {{item.tenXa}}
                            </option>
                        </select>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="exampleFormControlTextarea1" class="col-sm-2 col-form-label">Ghi chú</label>
                    <div class="col-sm-10">
                        <textarea v-model="requestModel.ghiChu" class="form-control" rows="3"></textarea>
                    </div>
                </div>
               
                <button type="button" @click="dosubmit()" class="btn btn-primary btn-lg" name="button">Đăng bài</button>
           <label class="card-title">__
               THAY MẶT NGƯỜI LÀM RƠI GIẤY TỜ - XIN CHÂN THÀNH CẢM ƠN HÀNH ĐỘNG ĐẦY TÍNH NHÂN VĂN CỦA BẠN</label>
            </div>
            <div class="form-group">
        </div>
        <div class="col-sm-3">

            <a >
                <div class="card-title">
                      <h3 class="alert alert-info" role="alert">Khu vực cho thuê quảng cáo</h3>
                  </div>
            <a href="http://viethanit.edu.vn" target="_self"> 
            <img src="@/assets/images/banner-hoc-bong.png"  class="card-img-top"  title="Viet Han IT - Một điểm tựa" alt="qc">   
                        <div class="card-title"> </div>
                        <img src="@/assets/images/vh2019.png" class="card-img-top" title="Viet Han IT - Một điểm tựa" alt="qc"> </a>
                        <div class="card-title"> </div>  
                          <a href="https://thegioididong.com" target="_self">   
                        <img src="@/assets/images/vm1.jpg" class="card-img-top" title="đi đến trang web của thế giới di động"  alt="qc">
                         <div class="card-title"> </div>    
                        <img src="@/assets/images/vm2.jpg" class="card-img-top" title="đi đến trang web của thế giới di động" alt="qc">
                          </a>
           
           <div class="card-title">
                      
                  </div>
            <div class="card-title">
                      <h5 class="alert alert-info" role="alert">LIÊN HỆ QUẢNG CÁO</h5>
                       <h6 class="alert alert-info" role="alert"> Holine:  0357485599</h6>
                        <h6 class="alert alert-info" role="alert"> Gmail:  LVTLIN98@GMAIL.COM</h6>
                  </div>
                  
            </a>
           
        </div>
        
    </div>
</template>
<script>
import axios from 'axios';
import { debuglog } from 'util';
export default {
    name: 'FindDocument',
    data() {
        return {
            requestModel:{
                maXa:null,
                maHuyen:null,
                maTinh:null,
                ghiChu:null,
                trangThai:null,
                hinhAnh:null,
                maNguoiNhat:null,
                maLoai: 1,
                ngayNhat:null,

                hoTen:null,
                maXaNn:null,
                soDienThoai:null,
                maTinhNn:null,
                maHuyenNn:null,
            },
            dataInit:{
                loaiGiayTo: {},
                dsTinh: { },
                dsHuyen:{},
                dsXaZ:{},
                dsTinhZ: { },
                dsHuyenZ:{},
                dsXaZ:{}
            }

        }
    },
    mounted(){
        var _this = this;
        axios.get("http://localhost:5004/dangtin/").then(response => {
            _this.dataInit.loaiGiayTo = response.data.listLoaiGiayTo;
            _this.dataInit.dsTinh = response.data.listTinh;
            _this.dataInit.dsTinhZ = response.data.listTinh;
        }).catch(error => console.log(error));

    },
    methods: {
        onChangeTinh: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/huyen/" + _this.requestModel.maTinhNn).then(response => {
                _this.dataInit.dsHuyen = response.data;
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => console.log(error));
        },
        changeTinhZ: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/huyen/" + _this.requestModel.maTinh).then(response => {
                _this.dataInit.dsHuyenZ = response.data;
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => console.log(error));
        },
        onChangeHuyen: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/xa/" + _this.requestModel.maHuyenNn).then(response => {
                _this.dataInit.dsXa = response.data;
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => console.log(error));
        },
        changeHuyenZ: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/xa/" + _this.requestModel.maHuyen).then(response => {
                _this.dataInit.dsXaZ = response.data;
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => console.log(error));
        },
        dosubmit: function(){
            var _this = this;
            var reqModel ={};

            reqModel.hoTen = _this.requestModel.hoTen;
            reqModel.soDienThoai = _this.requestModel.soDienThoai;
            reqModel.diaChiNguoiNhat = _this.requestModel.maXaNn;
            reqModel.maLoai = _this.requestModel.maLoai;
            reqModel.ngayNhat = _this.requestModel.ngayNhat;
            reqModel.noiNhat = _this.requestModel.maXa;
            reqModel.ghiChu = _this.requestModel.ghiChu;
       
            axios.post("http://localhost:5004/dangtin", reqModel).then(response => {
               if(response.data == true){
                   alert("Đăng tin thành công!");
               }else{
                   alert("Không thể đăng tin. Xin vui lòng thử lại!");
               }
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => console.log(error));

        },
    },  
}
</script>

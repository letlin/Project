<template>
    <div class="row">
        <div class="col-sm-3">
            <a href="#">
                <img src="@/assets/images/roi-giay-to1.jpg" class="card-img-top" alt="banner">
                <img src="@/assets/images/quality-comparison-blog.jpg" class="card-img-top" alt="banner">
            </a>
        </div>
        <div class="col-sm-6">
              <div class="card-title"> <label class="text-danger" role="alert">Mọi hành vi mua bán, đánh cắp giấy tờ, thông tin của người khác đề là hành vi vi phạm pháp luật.</label></div>
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

                    <select v-model="requestModel.maXan"  class="form-control mt-1">
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
                             <select v-model="requestModel.maTinhNd" name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                    <option v-for="(item, index) in dataInit.dsTinh" v-bind:key="index" v-bind:value="item.maTinh">
                        {{item.tenTinh}}
                    </option>
                    </select>

                              <select v-model="requestModel.maHuyenNd" name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                    <option v-for="(item, index) in dataInit.dsHuyen" v-bind:key="index" v-bind:value="item.maHuyen">
                        {{item.tenHuyen}}
                    </option>
                    </select>

                              <select v-model="requestModel.maXaNd" name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                    <option v-for="(item, index) in dataInit.dsXa " v-bind:key="index" v-bind:value="item.maXa">
                        {{item.tenXa}}
                    </option>
                    </select>
                        </div>
                    </div>

                <!-- <div class="form-group row">
                    <label class="col-sm-4 col-form-label">Sđt liên hệ</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" placeholder="Sđt...">
                    </div>
                </div> -->
                <div class="form-group row">
                    <label for="exampleFormControlTextarea1" class="col-sm-2 col-form-label">Ghi chú</label>
                    <div class="col-sm-10">
                        <textarea v-model="requestModel.ghiChu" class="form-control" rows="3"></textarea>
                    </div>
                </div>
                <div class="form-group">
                    <label class="">Vui lòng up ảnh giấy tờ đánh rơi</label>
                    <label class="text-danger">LUƯ Ý: CÓ THỂ CHỨA CÁC THÔNG TIN NHẠY CẢM, BẠN NÊN LÀM MỜ CÁC THÔNG TIN NHẠY CẢM NHƯ:CÁC MÃ SỐ BÍ MẬT DUY NHẤT,...ĐỂ ĐẢM BẢO SỰ AN TOÀN CHO CHÍNH CHỦ</label>
                     
                    <input type="file" class="form-control-file">
                    
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
           <img src="@/assets/images/banner-hoc-bong.png" class="card-img-top" alt="qc">   
            <div class="card-title"> </div>
            <img src="@/assets/images/rater-featured-image.jpg" class="card-img-top" alt="qc">
             <div class="card-title"> </div>
            <img src="@/assets/images/240_F_117782591_AdAQ13K6xrDkhokujeIJxKTg0Ki4DafD.jpg" class="card-img-top" alt="qc">
           
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
                dsXa:{}
            }

        }
    },
    mounted(){
        var _this = this;
        axios.get("http://localhost:5004/dangtin").then(response => {
            _this.dataInit.loaiGiayTo = response.data.listLoaiGiayTo;
            _this.dataInit.dsTinh = response.data.listTinh;
            // _this.dataInit.dsHuyen = response.data.listHuyen;
            // _this.dataInit.dsXa = response.data.listXa;
        }).catch(error => console.log(error));

    },
    methods: {
        onChangeTinh: function(){
            var _this = this;
            var reqMode = {};
            reqMode.type = 2;
            reqMode.maTinh = _this.requestModel.maTinhNn;
            reqMode.maHuyen = 0;
            
            axios.post("http://localhost:5004/dangtin/", reqMode).then(response => {
debugger
            _this.dataInit.dsHuyen = response.data;
            // _this.dataInit.dsXa = response.data.listXa;
        }).catch(error => console.log(error));
        },
        onChangeHuyen: function(){

        }
    },
}
</script>

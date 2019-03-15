<template>
    <div class="row">
        <div class="col-sm-3">
            <a href="#">
                <img src="@/assets/images/roi-giay-to1.jpg" class="card-img-top" alt="banner">
                <img src="@/assets/images/quality-comparison-blog.jpg" class="card-img-top" alt="banner">
            </a>
        </div>
        <div class="col-sm-6">
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
                    <select v-model="requestModel.maTinhNn" name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                    <option>Tỉnh/thành phố</option>
                    </select>
                    <select v-model="requestModel.maHuyenNn" name="exampleFormControlSelect2" class="form-control" id="exampleFormControlSelect2">
                    <option>huyện/thị trấn</option>
                    </select>
                    <select v-model="requestModel.maXaNn" name="exampleFormControlSelect3" class="form-control" id="exampleFormControlSelect3">
                    <option>phường/xã</option>
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
                            <select v-model="requestModel.maTinh" name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                            <option>Tỉnh/thành phố</option>
                            </select>
                            <select  v-model="requestModel.maHuyen" name="exampleFormControlSelect2" class="form-control" id="exampleFormControlSelect2">
                            <option>huyện/thị trấn</option>
                            </select>
                            <select  v-model="requestModel.maXa" name="exampleFormControlSelect3" class="form-control" id="exampleFormControlSelect3">
                            <option>phường/xã</option>
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
                    <label class="text-danger">Vui lòng up ảnh giấy tờ đánh rơi</label>
                    <label class="text-danger">**LƯU Ý: vì đảm bảo sự an toàn cho thông tin cá nhân của chính chủ yêu cầu cần che đi những thông tin như:Số CMND, số thẻ ngân hàng và một số thông tin nhạy cảm khác,...nếu bạn không thực hiện điều này thì chúng tôi sẽ tiến hành sửa đổi ảnh mà bạn đã upload lên hệ thống để đảm an toàn- trật tự xã hội..XIN CẢM ƠN</label>
                    <input type="file" class="form-control-file">
                    
                </div>
                <button type="button" @click="dosubmit()" class="btn btn-primary btn-lg" name="button">Đăng bài</button>
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
                maLoai:null,
                ngayNhat:null,

                hoTen:null,
                maXaNn:null,
                soDienThoai:null,
                maTinhNn:null,
                maHuyenNn:null,
            },
            posts: {}
        }
    },
    methods:{
        dosubmit: function(){
            var _this = this;
            //http://localhost:50616/dangtin/dangtin
            axios.post("http://localhost:50616/dangtin", _this.requestModel).then(response => {

                _this.posts = response.data;
            })
            .catch(e => {
                //this.errors.push(e)
            })
        }
    }
}
</script>


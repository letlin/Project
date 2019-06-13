<template>
<div class="container-fluid">
    <div class="row">
        <div class="col-md-6 col-sm-6">
            <div class="card">
                <h5 class="card-header">Đây là chức năng giúp bạn tìm kiếm nhanh có ai đã nhặt được giấy tờ của bạn hay chưa</h5>
                <div class="card-body">
                    <h5 class="card-title">Form tìm kiếm</h5>
                    <div class="row">
                        <div class="col-sm-12">
                            <label for="maTinhNn">Tỉnh/Thành phố</label>
                            <select v-model="requestModel.MaTinh" @change="onChangeTinh()" class="form-control" id="maTinhNn">
                                <option v-for="(item, index) in dataInit.dsTinh" v-bind:key="index" v-bind:value="item.maTinh">
                                    {{item.tenTinh}}
                                </option>
                            </select>
                            <label for="maHuyenNn">Quận/Huyện</label>
                            <select v-model="requestModel.MaHuyen" @change="onChangeHuyen()" class="form-control mt-1" id="maHuyenNn">
                                <option v-for="(item, index) in dataInit.dsHuyen" v-bind:key="index" v-bind:value="item.maHuyen">
                                    {{item.tenHuyen}}
                                </option>
                            </select>
                            <label for="maXaNn">Xã/Phường</label>
                            <select v-model="requestModel.MaXa"  class="form-control mt-1" id="maXaNn">
                                <option v-for="(item, index) in dataInit.dsXa" v-bind:key="index" v-bind:value="item.maXa">
                                    {{item.tenXa}}
                                </option>
                            </select>
                            <label for="maLoai">Loại giấy tờ</label>
                            <select v-model="requestModel.MaLoai" class="form-control" id="maLoai">
                                <option v-for="(item, index) in dataInit.loaiGiayTo" v-bind:key="index" v-bind:value="item.maLoai">
                                    {{item.tenLoai}}
                                </option>
                            </select>
                            <label for="ngayNhatFrom">Khoảng thời gian thất lạc</label>
                            <div class="input-check">
                                <input v-model="requestModel.NgayNhatFrom" type="date" class="form-control d-inline p-2"  id="ngayNhatFrom" style="width: 250px">
                                Đến
                                <input v-model="requestModel.NgayNhatTo" type="date" class="form-control d-inline p-2"  id="ngayNhatTo" style="width: 250px">
                            </div>
                        </div> 
                        <div class="col-md-12 col-sm-12 mt-2 text-center">
                            <button type="button" @click="timkiem()" class="btn btn-primary btn-lg" name="button">tìm kiếm</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- ket qua -->
        <div v-if="Object.size(dataSearch) > 0" class="col-sm-6 col-md-6">
            <div class="card-title">
               Đã tìm được<label class="font-weight-bold text-danger" role="alert" style="font-size: 40px;">
                    {{Object.size(dataSearch)}}
                </label> kết quả.
            </div>
            <div v-for="(item, index) in dataSearch" :key="index" class="card">
                <div class="card-body">
                    <div class="card-title">
                        <h3 class="alert alert-info" role="alert">Tìm chính chủ của giấy tờ thất lạc</h3>
                    </div>
                    <div class="row">
                        <div class="col-sm-5">
                            <img src="@/assets/images/Canh.jpg" class="card-img-top" alt="">
                        </div>
                        <div class="col-sm-6">
                            <p><u>Thông tin về người nhặt được giấy tờ </u></p>
                            <p>Họ tên: {{item.hoTen}}</p>
                            <p>Số điện thoại liên hệ: {{item.soDienThoai}}</p>
                            <p>Ghi chú: {{item.ghiChu}}</p>
                            <p><u>Thông tin về giấy tờ đang tìm chính chủ </u></p>
                            <p>Loại Giấy tờ: {{item.tenLoai}}</p>
                            <p>Ngày nhặt được: {{item.ngayNhat}}</p>
                            <p>Nơi nhặt được: {{item.tenXa}}-{{item.tenHuyen}}-{{item.tenTinh}} </p>
                        </div>
                        <vue-goodshare-facebook
                                :page_url="urlShareFacebook"
                                title_social="Facebook"
                                has_counter
                                has_icon
                        ></vue-goodshare-facebook>
                        <vue-goodshare-twitter 
                        button_design="gradient"
                        :page_url="urlShareFacebook" 
                        has_icon
                        ></vue-goodshare-twitter>
                    </div>
                </div>
            </div>
        </div>
        <div v-else class="col-sm-6 text-danger col-md-6">
            Không tìm thấy dữ liệu
        </div>
    </div>
    <div class="row mt-3">
    </div>
    <modal-alert
        v-if="isShowModal"
        :dataShow="err"
        @closedModal="isShowModal = false"
    />
</div>
</template>
<script>
/* eslint-disable */
import axios from 'axios';
import ModalAlert from '../components/ModalAlert.vue';
import VueGoodshareFacebook from 'vue-goodshare/src/providers/Facebook';
import VueGoodshareTwitter from 'vue-goodshare/src/providers/Twitter.vue';
Object.size = function(obj) {
    var size = 0, key;
    for (key in obj) {
        if (obj.hasOwnProperty(key)) size++;
    }
    return size;
};
export default {
    components:{
        ModalAlert,
        VueGoodshareFacebook,
        VueGoodshareTwitter
    },
    name: 'FindDocument',
    data() {
        return {
            err: null,
            isShowModal: false,
            requestModel:{
                MaXa:null,
                MaHuyen:null,
                MaTinh:null,
                MaLoai: 1,
                NgayNhatFrom:null,
                NgayNhatTo:null,
            },
            dataInit:{
                loaiGiayTo: {},
                dsTinh: { },
                dsHuyen:{},
                dsXa:{},
            },
            dataSearch:{},
        }
    },
    mounted(){
        var _this = this;
        axios.get("http://localhost:5004/dangtin/").then(response => {
            _this.dataInit.loaiGiayTo = response.data.listLoaiGiayTo;
            _this.dataInit.dsTinh = response.data.listTinh;
        }).catch(error => function(){
                _this.err = error;
                _this.isShowModal = true;
                console.log(error)
            });
    },
    methods: {
        onChangeTinh: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/huyen/" + _this.requestModel.MaTinh).then(response => {
                _this.dataInit.dsHuyen = response.data;
            }).catch(error => function(){
                _this.err = error;
                _this.isShowModal = true;
                console.log(error)
            });
        },
        onChangeHuyen: function(){
            var _this = this;
            axios.get("http://localhost:5004/api/xa/" + _this.requestModel.MaHuyen).then(response => {
                _this.dataInit.dsXa = response.data;
                // _this.dataInit.dsXa = response.data.listXa;
            }).catch(error => function(){
                console.log(error);
                _this.err = error;
                _this.isShowModal = true;
                });
        },
       
        timkiem: function(){
            var _this = this;
            debugger
            axios.post("http://localhost:5004/api/search", _this.requestModel).then(response => {
                //tim kiem
                _this.dataSearch = response.data;
            }).catch(error => function(){
                debugger
                console.log(error);
                _this.err = error;
                _this.isShowModal = true;
                });
        }
    },  
}
</script>
